namespace ApiProduct.Models;
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Stock { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
