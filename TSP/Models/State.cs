using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP.Models
{
    public class CurrentState
    {
        public Population Population { get; set; }
        public List<int> BestFitnessHistory { get; set; } = new();
        public List<int> AverageFitnessHistory { get; set; } = new();
        public bool IsPaused { get; set; } = false;
        public CancellationTokenSource CancellationTokenSource { get; set; }
        public int LastGeneration { get; set; } = 0;
        public int BestFitness { get; set; } = int.MaxValue;
        public int StagnationCounter { get; set; } = 0;
        public bool QuickEnd { get; set; } = false;
        public DateTime StartTime { get; set; }
        public int Speed { get; set; } = 250;
        public bool QuickEndWithoutProceeding { get; set; } = false;
    }
}
