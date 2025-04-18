using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP.Models
{
    public class Settings
    {
        public int populationsSuze { get; set; }
        public int numPopulations { get; set; }
        public int Generations { get; set; }
        public int StagnationLimit { get; set; }
        public double ParentRatio { get; set; }
        public double CrossoverRatio { get; set; }
        public double MutationRatio { get; set; }
        public string SelectionType { get; set; } = "x";
        public string CrossoverType { get; set; } = "x";
        public string MutationType { get; set; } = "x";
        public string SavePath { get; set; } = "x";
    }
}
