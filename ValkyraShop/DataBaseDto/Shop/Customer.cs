using System.ComponentModel.DataAnnotations;

namespace ValkyraShop.DatabaseDto.Shop
{
    public class Customer : BaseDbDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Language Language { get; set; }
    }
}
