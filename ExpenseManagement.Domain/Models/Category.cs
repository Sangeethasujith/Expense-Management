using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseManagement.Domain.Models
{
    public class Category:Entity
    {
        public string Name { get; set; }

        public IEnumerable<Expense> Expenses { get; set; }
    }
}
