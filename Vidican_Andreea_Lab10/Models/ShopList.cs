using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace Vidican_Andreea_Lab10.Models
{
     public class ShopList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
