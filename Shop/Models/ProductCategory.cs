namespace Shop.Models
{
    public class ProductCategory
    {
        /// <summary>
        /// Идентификатор продукта
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Идентификатор категории 
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// Продукт
        /// </summary>
        public Product Product { get; set; }
        /// <summary>
        /// Категория
        /// </summary>
        public Category Category { get; set; }
    }
}
