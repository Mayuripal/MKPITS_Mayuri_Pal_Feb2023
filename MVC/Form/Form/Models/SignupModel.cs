namespace Form.Models
{
    public class SignupModel
    {
        public string UserName { get; set; }
        public string gender { get; set; }
        public bool sub1 { get; set; }
        public bool sub2 { get; set; }
        public city SelectCity { get; set; }
    }

    public enum city
    {
        Nagpur, Mumbai, Pune
    }
}
