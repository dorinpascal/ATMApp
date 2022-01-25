using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using HotChocolate;

namespace GraphQlAPI.Model
{
    public class Transaction
    {
        [Key] public int id { get; set; }
       // [Required] public DateTime Date { get; set; }
        public string Action { get; set; }
        public double Amount { get; set; }
        public Account Account { get; set; }
    }
}