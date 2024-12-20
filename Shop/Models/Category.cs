namespace Shop.Models
{
    public class Category
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public int Id { get; set; } 
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
