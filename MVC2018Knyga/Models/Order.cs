using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MVC2018Knyga.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        [Remote("CheckUserName","Account", HttpMethod = "POST")]
        public string UserName { get; set; }
        [Required]
        [StringLength(160)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(160)]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        [Range(typeof(decimal),"0.00","49.99")]
        public decimal Price { get; set; }
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-za-z0-9.-]+\.[A-Za-z]{2,4}",ErrorMessage ="Bad email adress.")]
        public string Email { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("Email")]
        public string EmailConfirm { get; set; }
        public decimal Total { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}