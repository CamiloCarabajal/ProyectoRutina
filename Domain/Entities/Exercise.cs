using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Exercise
    {
        public string? Name { get; set; }
        public string? Category { get; set; }
        public Machine? MachineInUse { get; set; } // Relacion con Maquina
    }
}
