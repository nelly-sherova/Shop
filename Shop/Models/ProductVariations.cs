namespace Shop.Models
{
    public class ProductVariations
    {
        /// <summary>
        /// Уникальный идентификатор 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Идентификатор товара
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Цвет товара 
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Идентификатор размера 
        /// </summary>
        public int ProductSizeId { get; set; }
        /// <summary>
        /// Объект размера для данного цвета 
        /// </summary>
        public ProductSize ProductSize { get; set; }   
        /// <summary>
        /// Количество доступных 
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// Длина
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// Ширина плеч
        /// </summary>
        public double ShoulderWidth { get; set; }
        /// <summary>
        /// Обхват груди 
        /// </summary>
        public double Bust { get; set; }
        /// <summary>
        /// Обхват талии 
        /// </summary>
        public double Waist { get; set; }
        /// <summary>
        /// Обхват бедер 
        /// </summary>
        public double Hip { get; set; }
        /// <summary>
        /// Длина рукава 
        /// </summary>
        public double SleeveLength { get; set; }
        /// <summary>
        /// Тип застежки (пуговицы, молния, липучка, шнуровка)
        /// </summary>
        public string Clasp { get; set; }


    }
}
