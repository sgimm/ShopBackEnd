using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValkyraShop.DataBase;
using ValkyraShop.DatabaseDto.Shop;
using ValkyraShop.Dtos;
using ValkyraShop.Helpers;

namespace ValkyraShop.Services
{
    public class RegistrationService : IRegistrationService
    {
        private RegisterRepository _valkyraRegisterRepository = null;
        private IConfiguration _configuration = null;
        public RegistrationService(ShopDbContext dbContext, IConfiguration configuration)
        {
            _valkyraRegisterRepository = new RegisterRepository(dbContext);
            _configuration = configuration;
        }

        public ValidationResult Register(CustomerWebAccount customerWebAccount)
        {
            CustomerWebAccount _customerWebAccount = customerWebAccount;
            ValidationResult _validationResult = _valkyraRegisterRepository.EmailExists(customerWebAccount);
            if (_validationResult.ResultCode == 0)
            {
                _valkyraRegisterRepository.CreateCustomerWebAccount(_customerWebAccount);
                EmailValidation emailValidation = _valkyraRegisterRepository.CreateValidationLink(_customerWebAccount);
                SendMailHelper sendMailHelper = new SendMailHelper(_configuration);
                sendMailHelper.SendMail(customerWebAccount, emailValidation);
            }
            return _validationResult;
        }

        public void Validate(string id)
        {
            if (!string.IsNullOrWhiteSpace(id) && id != "undefined")
            {
                EmailValidation emailValidation = _valkyraRegisterRepository.ValidationExist(id);
                if (emailValidation != null)
                {
                    CustomerWebAccount customerWebAccount = _valkyraRegisterRepository.GetCustomerWebAccount(emailValidation.CustomerWebAccountId);
                    customerWebAccount.Verified = true;
                    _valkyraRegisterRepository.UpdateCustomerWebAccount(customerWebAccount);
                    
                }
                else
                {
                    throw new Exception("Validation not found for: " + id );
                }
            }
            else
            {
                throw new Exception("Validation Id is null or empty");
            }
        }
    }
}
