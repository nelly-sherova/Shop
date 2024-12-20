namespace Shop.Models
{
    public class PicUrl
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int ProductVariationtId { get; set; }  
        public ProductVariation ProductVariation { get; set; }
    }
}
