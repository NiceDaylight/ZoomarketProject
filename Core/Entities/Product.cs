namespace Core.Entities
{
    public class Product : BaseEntity
    {
        public Product()
        {
        }
        public string Name { get; set; } = "Product name";
        public string Description { get; set; } = "Product description";
        public decimal Price { get; set; } = 1000;
        public string ProductCharacteristics { get; set; }
        public string PictureUrls { get; set; }
        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }
        public ProductTypeFor ProductTypeFor { get; set; }
        public int ProductTypeForId { get; set; }
        public ProductBrand ProductBrand { get; set; }
        public int ProductBrandId { get; set; }
    }
}