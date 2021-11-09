using System;

namespace ValkyraShop.DatabaseDto.Shop
{
    public class CustomerWebToken:BaseDbDto
    {
        public string Token { get; set; }
        public DateTime Expire { get; set; }
        public int CustomerWebAccountId { get; set; }
        public CustomerWebAccount CustomerWebAccount { get; set; }
    }
}
