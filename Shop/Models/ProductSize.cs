using Shop.Enums;

namespace Shop.Models
{
    public class ProductSize
    {
        /// <summary>
        /// Униклаьный идентификатор 
        /// </summary>
        public int Id { get; set; } 
        /// <summary>
        /// Размер 
        /// </summary>
        public string Size { get; set; }
        /// <summary>
        /// Список вариаций этого цвета 
        /// </summary>
        public ICollection<ProductVariation> Variations { get; set; }
        
        
    }
}
