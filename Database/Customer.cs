using System.ComponentModel.DataAnnotations;

namespace NSK_Food_City.Database
{
    public class Customer
    {
        [Key]public Guid CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
