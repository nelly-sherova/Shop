using Shop.Enums;

namespace Shop.Models
{
    public class Product
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
        /// Цена
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Стандарт размера (1 - числовой, 2 - буквенный)
        /// </summary>
        public SizeStandart SizeStandart { get; set; }
        /// <summary>
        /// Пол (1 - женский, 2 - мужской)
        /// </summary>
        public Sex?  ProductSex { get; set; }
        /// <summary>
        /// Категории 
        /// </summary>
        public List<ProductCategory> ProductCategories { get; set; }
        /// <summary>
        /// Дата доставки 
        /// </summary>
        public DateTime DeliveryDate { get; set; }
        /// <summary>
        /// Материа или ткань 
        /// </summary>
        public string Material { get; set; }
        /// <summary>
        /// Страна произведение 
        /// </summary>
        public string CountryOfOrigin { get; set; }
        /// <summary>
        /// Есть ли возврат 
        /// </summary>
        public bool Return { get; set; }
        /// <summary>
        /// Сезонность 
        /// </summary>
        public ICollection<Season> Season { get; set; }
        /// <summary>
        /// Состав ткани 
        /// </summary>
        public string Compound { get; set; }
        /// <summary>
        /// Бренд, Фирма или марка одежды 
        /// </summary>
        public string Brand { get; set; }
        public ICollection<ProductVariation> ProductVariation { get; set; } 



    }
}
