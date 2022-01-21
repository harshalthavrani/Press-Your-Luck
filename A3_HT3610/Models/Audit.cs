//Name: Harshal Thavrani
//    Student Id: 8733610
//    Assignment 3 
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace A3_HT3610.Models
{
    public class Audit
    {
        [Key]
        public int AuditId { get; set; }

        public string PlayerName { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public double Amount { get; set; }

        public int AuditTypeId { get; set; }

        [ForeignKey("AuditTypeId")]

        public AuditType AuditType { get; set; }

    }
}
