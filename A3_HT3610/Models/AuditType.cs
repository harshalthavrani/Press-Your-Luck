//Name: Harshal Thavrani
//    Student Id: 8733610
//    Assignment 3 
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace A3_HT3610.Models
{
    public class AuditType
    {
        [Key]
        public int AuditTypeId { get; set; }

        public string Name { get; set; }
    }
}
