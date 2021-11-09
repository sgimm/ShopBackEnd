using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ValkyraShop.Services;
using ValkyraShop.DataBase;
using ValkyraShop.DatabaseDto.Shop;
using ValkyraShop.Dtos;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;

namespace ValkyraShop.Services
{
    public class LoginService : ILoginService
    {
        private RegisterRepository _valkyraRegisterRepository = null;
        public LoginService(ShopDbContext dbContext)
        {
            _valkyraRegisterRepository = new RegisterRepository(dbContext);
        }

        public string Login(WebLogin webLogin, string key)
        {
            CustomerWebAccount customerWebAccount = _valkyraRegisterRepository.GetAccountForLogin(webLogin);
            CustomerRegisterLoginViewModel customerRegisterLoginViewModel = new CustomerRegisterLoginViewModel();
            customerRegisterLoginViewModel.FunctionName = "LoginResult";
            if (customerWebAccount == null)
            {
                return string.Empty;
            }


            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            byte[] tokenKey = Encoding.UTF8.GetBytes(key);
            SecurityTokenDescriptor securityTokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, customerWebAccount.Email),
                    new Claim(ClaimTypes.NameIdentifier, customerWebAccount.Id.ToString())
                }),
                Expires = DateTime.Now.AddHours(3),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };
            SecurityToken securityToken = tokenHandler.CreateToken(securityTokenDescriptor);
            return tokenHandler.WriteToken(securityToken);
        }
    }
}
