using System;
using System.ComponentModel.DataAnnotations;

namespace Commander.Models
{
    public class invoice 
    {
        [Key]
        public Guid invoice_id { get; set; }
        public Guid user_id { get; set; }
        public double total_amount { get; set; }
        // public double open_balance { get; set; }

        // public System.DateTime date { get; set; }
        // public System.DateTime due_date { get; set; }

        // public int invoice_number { get; set; }

        // public System.DateTime billing_period_from { get; set; }
    }
}