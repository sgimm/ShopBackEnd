using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValkyraShop.Dtos
{
    public class CustomerAddressDto
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
        public int CountryId { get; set; }
        public int CustomerId { get; set; }
    }
}
