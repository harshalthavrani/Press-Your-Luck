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
    public class Tile
    {
        [Key]
        public int TileIndex { get; set; }
        public double Value { get; set; }
        public bool Visible { get; set; }

        public string GetPicturePath()
        {
            string imgFolder = "/images/";
            string imgFilePath = "";
            if (!Visible)
            {
                imgFilePath = "unknown.png";
            }
            else
            {
                if (Value > 0.0)
                {
                    imgFilePath = "money.png";
                }
                else
                {
                    imgFilePath = "bust.png";
                }
            }
            return imgFolder + imgFilePath;
        }
    }
}
