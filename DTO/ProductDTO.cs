using System.ComponentModel.DataAnnotations;

namespace NSK_Food_City.DTO
{
    public class ProductDTO
    {
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public int Price { get; set; }
    }
}
