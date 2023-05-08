namespace Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Product name";
        public string Description { get; set; } = "Product description";
        public string ProductCharacteristics { get; set; } = "Product characteristics";
        public decimal Price { get; set; } = 1000;
        public string PictureUrl { get; set; } = "https://picsum.photos/seed/picsum/200/300";
        public string ProductType { get; set; } = "Type";
        public string ProductTypeFor { get; set; } = "TypeFor";
        public string ProductBrand { get; set; } = "Brand";
    }
}