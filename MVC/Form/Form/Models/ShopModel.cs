namespace Form.Models
{
    public class ShopModel
    {
        public TeaType SelectTeaType { get; set; }
    }

    public enum TeaType
    {
        BlackTea,GreenTea,Tea,Coffee
    }
}
