namespace Form.Models
{
    public class ProductDetailsModel
    {
        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }

        public prodname GetProductName { get; set; }

        public int price { get; set; }

        public int qty { get; set; }
    }

    public enum prodname
    {
        mouse,keyboard,ram,monitor
    }
}
