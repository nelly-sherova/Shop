﻿namespace Shop.Models
{
    public class Season
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }  
        public Product Product { get; set; }

    }
}
