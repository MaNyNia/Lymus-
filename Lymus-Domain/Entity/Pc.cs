using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lymus_Domain.Entity
{
    public class Pc
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public DateTime DateCreate { get; set; }

        public Type TypePc { get; set; }
    }
}
