using System;
using System.Collections.Generic;
using System.Text;

namespace Pedidos.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client() {}
        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = BirthDate;
        }

        public override string ToString() 
        {
            StringBuilder str = new StringBuilder();
            str.Append(Name);
            str.Append($" ({BirthDate.ToString("dd/MM/yyyy")}) - ");
            str.Append(Email);
            return str.ToString();
        }
    }
}