using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GraphQlAPI.Model
{
    public class Account
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string AccountNumber { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Amount { get; set; }
        public IList<Transaction>Transactions { get; set; }
    }
}