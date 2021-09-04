using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace livrariaAPIs.Models
{
    public class Produto
    {
        public string ID { get; set;}
        public string Name { get; set;}
        public double Price { get; set;}
        public int Quantity { get; set; }
        public string Category { get; set; }
        public string Img { get; set;}
    }
}
