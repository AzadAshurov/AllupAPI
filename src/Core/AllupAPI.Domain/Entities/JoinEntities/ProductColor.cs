﻿namespace AllupAPI.Domain.Entities
{
    public class ProductColor
    {
        //Relation
        public int ProductId { get; set; }
        public int ColorId { get; set; }
        public Product Product { get; set; }
        public Color Color { get; set; }
    }
}
