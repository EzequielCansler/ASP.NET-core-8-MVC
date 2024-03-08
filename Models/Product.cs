﻿namespace NehuenOrganico.Models
{
     public class Product
     {
            public int ProductId { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Category { get; set; } = string.Empty ;
            public string? Description { get; set; } = string.Empty;
            public float Price { get; set; }
            public string ImageUrl { get; set; } = string.Empty;
     }
}

