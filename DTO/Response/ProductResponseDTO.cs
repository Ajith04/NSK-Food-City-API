using System.ComponentModel.DataAnnotations;

namespace NSK_Food_City.DTO.Response
{
    public class ProductResponseDTO : ProductDTO
    {
        public Guid ProductId { get; set; }
    }
}
