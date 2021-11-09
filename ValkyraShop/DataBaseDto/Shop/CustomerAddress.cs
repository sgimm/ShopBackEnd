using System.ComponentModel.DataAnnotations;

namespace ValkyraShop.DatabaseDto.Shop
{
    public enum AddressTypes
    {
        Invoice,
        Delivery
    }
    public class CustomerAddress:BaseDbDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string ZipCode { get; set; }
        [Required]
        public string City { get; set; }
        public string AddressInformation { get; set; }
        [Required]
        public Country Country { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}