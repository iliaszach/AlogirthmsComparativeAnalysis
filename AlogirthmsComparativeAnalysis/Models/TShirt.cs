using AlogirthmsComparativeAnalysis.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlogirthmsComparativeAnalysis.Models
{
    public class TShirt
    {
        public Color Color;
        public Size Size;
        public Fabric Fabric;
        public decimal Price { get; set; }

        public TShirt(Color color, Size size, Fabric fabric)
        {
            Color = color;
            Size = size;
            Fabric = fabric;
        }
    }
}
