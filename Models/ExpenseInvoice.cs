using System;
using System.Collections.Generic;
using System.Text;

namespace head_chef.Models
{
    // Клас видаткової накладної (списання продуктів)
    public class ExpenseInvoice
    {
        public int InvoiceNumber { get; set; }
        public DateTime CreationDate { get; set; }
        public List<RecipeIngredient> WrittenOffItems { get; set; }
        public decimal TotalSum { get; set; }

        public ExpenseInvoice()
        {
            WrittenOffItems = new List<RecipeIngredient>();
        }
    }
}
