using System;

namespace InvoiceManager
{
    public class Invoice
    {
        private string _name;
        private decimal _amount;
        private DateTime _date;

        public Invoice(string[] split)
        {
            _name = split[0];
            _amount = decimal.Parse(split[1]);
            _date = DateTime.Parse(split[2]);
        }

        public string Name => _name;
        public decimal Amount => _amount;
        public DateTime Date => _date;
    }
}
