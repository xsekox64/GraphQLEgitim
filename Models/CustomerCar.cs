using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.ObjectPool;

namespace GraphQLEgitim.Models
{
    public class CustomerCar
    {
        [Key]
        public int CustomerCarId { get; set; }
        public int CustomerId { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string ModelYear { get; set; }
        public string Kilometer { get; set; }
        public string Plaka { get; set; }
        public string SasiNo { get; set; }
        public string MotorNo { get; set; }        
        public Customer Customer{get; set;}
         
    }
}
