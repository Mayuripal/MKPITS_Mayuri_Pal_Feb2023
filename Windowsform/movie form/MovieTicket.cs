using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    abstract class MovieTicket
    {
        //feild to calculate movie ticket
        public string Movie_Name { get; set; }
        
        public string Theater_Name { get; set; }

        public int Seat_Number { get; set; }

        public string Show_Time { get; set; }

        public float Ticket_Price { get; set; }

        //method to calculate movie ticket
        public abstract string Calculate_Ticket_Price();

      
    }
    class Online_Booking :MovieTicket
    {
        //CONSTRUCTOR
        public Online_Booking(int Seat_Number,float Ticket_Price)
        {
            this.Ticket_Price=Ticket_Price;
            this.Seat_Number=Seat_Number;
        }
        public float discount { get; set; }
        public override string Calculate_Ticket_Price()
        {
            float tp = Seat_Number * Ticket_Price ;
            discount = tp * 0.10f;
            tp = tp - discount;
            return tp.ToString();
        }

    }
    class Boxoffice_Booking:Movie_Ticket
    {
        public  Boxoffice_Booking(int Seat_Number, float Ticket_Price)
        {
            this.Ticket_Price = Ticket_Price;
            this.Seat_Number = Seat_Number;
        }
        public float bookingfees { get; set; }
        public override string Calculate_Ticket_Price()
        {
            float tp = Seat_Number * Ticket_Price ;
            tp = tp + 20;
            
            return tp.ToString();
        }
    }

}
