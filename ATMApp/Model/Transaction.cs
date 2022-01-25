using System;

namespace ATMApp.Model
{
    public class Transaction
    {
        public int id { get; set; }
        public DateTime Date { get; set; }
        public string Action { get; set; }
    }
}