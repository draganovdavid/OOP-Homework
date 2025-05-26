using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace.Models
{
    public class PizzaSize
    {
        public PizzaSize(string name, int weight)
        {
            Name = name;
            DoughWeight = weight;
        }

        public string Name { get; }
        public int DoughWeight { get; }
    }

}
