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
    public class Player
    {
        [Key]

        [Required(ErrorMessage = "Please enter a Name to play the game")]
        public string PlayerName { get; set; }

        [Required(ErrorMessage = "Please enter a total number of coins value")]
        [Range(1, 10000, ErrorMessage = "total coins values must be an integer between 1.00 and 10,000.00")]
        public double TotalCoins { get; set; }
    }
}
