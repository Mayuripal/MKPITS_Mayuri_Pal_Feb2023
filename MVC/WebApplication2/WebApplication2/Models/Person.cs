namespace WebApplication2.Models
{
    public class Person
    {
        public string Name;
        public string Email;
        public int PhoneNumber;

        public  Person(string name, string email, int phoneNumber)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public string PersonName { get { return Name; } }

        public string PersonMail { get { return Email; } }  

        public int PersonNumber { get { return PhoneNumber; } }

    }
    
}
