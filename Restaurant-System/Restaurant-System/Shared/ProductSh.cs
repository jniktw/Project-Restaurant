namespace Restaurant_System.Shared
{
    public class ProductSh
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int ActualNumber { get; set; }
        public int RequiredNumber { get; set; }
        public string Unit { get; set; }

        public ProductSh Copy()
        {
            return new ProductSh
            {
                Id = this.Id,
                ProductName = this.ProductName,
                ActualNumber = this.ActualNumber,
                RequiredNumber = this.RequiredNumber,
                Unit = this.Unit
            };
        }
    }
   

}
