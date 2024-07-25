using System.ComponentModel.DataAnnotations;

namespace NSK_Food_City.Database
{
    public class Product
    {
        [Key]public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public int Price { get; set; }
    }
}
