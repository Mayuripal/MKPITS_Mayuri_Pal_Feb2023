using Microsoft.AspNetCore.Http.Connections;

namespace Form.Models
{
    public class BankModel
    {
        public int AccountNumber { get; set; }

        public int Amount { get; set;}

        public transtype GetTranstype { get; set; }
    }

    public enum transtype
    {
        Deposite,Widthdraw
    }
}
