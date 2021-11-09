using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValkyraShop.Dtos
{
    public class CustomerRegisterLoginViewModel
    {
        public int CustomerId { get; set; }
        public string FunctionName { get; set; }
        public string ValidationResultMessage { get; set; }
        public string Token { get; set; }
        public DateTime Expire { get; set; }
    }
}
