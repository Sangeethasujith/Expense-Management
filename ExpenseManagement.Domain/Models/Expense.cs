using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseManagement.Domain.Models
{
    public class Expense:Entity
    {
        public string  Name { get; set; }
        public double Amount { get; set; }
        public DateTime ExpenseDate { get; set; }
        public int CategoryId { get; set; }
        public string PaymentType { get; set; }

        public Category Category { get; set; }

    }
}
