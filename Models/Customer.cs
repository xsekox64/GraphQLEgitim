using System;
using System.ComponentModel.DataAnnotations;

namespace GraphQLEgitim.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string  CustomerName { get; set; }
        public string  CustomerSurname { get; set; }
        public string  CustomerPhone { get; set; }
        public string  CustomerEmail { get; set; }
        public string  CustomerAddress { get; set; }
        public DateTime AddDateTime { get; set; }
        public string  CustomerTcNo { get; set; }
        public bool  Active { get; set; }    

        public ICollection<CustomerCar> CustomerCars {get; set;} = new List<CustomerCar>();
        
    }
}
