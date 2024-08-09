using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Routine
    {
        public string Name { get; set; }
        public string Difficulty { get; set; }
        public string Duration { get; set; }
        List<Exercise> ExerciseList { get; set; } // Relacion con Ejercicio

    }
}
