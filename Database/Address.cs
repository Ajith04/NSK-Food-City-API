using System.ComponentModel.DataAnnotations;

namespace NSK_Food_City.Database
{
    public class Address
    {
        [Key]public Guid AddressId { get; set; }
        public string HouseNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
    }
}
