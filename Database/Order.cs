using System.ComponentModel.DataAnnotations;

namespace NSK_Food_City.Database
{
    public class Order
    {
        [Key]public Guid OrderId { get; set; }
        public Guid CustomerCustomerId { get; set; }
        public Guid ProductProductId { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderQuantity { get; set; }
    }
}
