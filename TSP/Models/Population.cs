using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP.Models
{
    public class Population
    {
        public List<Chromosome> basePopulation = new();
        public List<Chromosome> parentPopulation = new();

        public Chromosome baseChromosome;
        private int _numberOfPopulations;
        public string populationID;
        public Population(int numberOfPopulations, int numberOfGenes)
        {
            _numberOfPopulations = numberOfPopulations;
            baseChromosome = new(numberOfGenes);
            createBasePopulation();
            parentPopulation = new List<Chromosome>(basePopulation);
            populationID = Guid.NewGuid().ToString();
        }
        public void resetPopulation()
        {
            parentPopulation = new List<Chromosome>(basePopulation);
        }
        private void createBasePopulation()
        {
            for (int i = 0; i < _numberOfPopulations; i++)
            {
                basePopulation.Add(baseChromosome.Shuffle());
            }
        }

        public void createNextPopulation(string selectionType, string crossoverType, string mutationType, double parentRatio, double crossoverRatio, double mutationRatio)
        {
            int add = (_numberOfPopulations % 2 == 1) ? 1 : 0;

            // Selekcja rodziców do krzyżowania
            List<Chromosome> selectedParents = Operations.Selections.Select(parentPopulation, selectionType);

            // Krzyżowanie wybranych rodziców
            List<Chromosome> offspring = Operations.Crossovers.ApplyCrossover(selectedParents, crossoverType, crossoverRatio);

            // Mutacja potomstwa
            List<Chromosome> mutatedOffspring = Operations.Mutations.ApplyMutation(offspring, mutationType, mutationRatio);

            parentPopulation = Population.CombinePopulations(parentPopulation, mutatedOffspring, parentRatio);
        }

        public static List<Chromosome> CombinePopulations(List<Chromosome> parents, List<Chromosome> offspring, double parentRatio)
        {
            int parentCount = (int)(parents.Count * parentRatio);
            int offspringCount = parents.Count - parentCount;

            List<Chromosome> combinedPopulation = parents.OrderBy(c => c.Fitness).Take(parentCount)
                .Concat(offspring.OrderBy(c => c.Fitness).Take(offspringCount)).ToList();

            return combinedPopulation;
        }

        public int BestFitness() => parentPopulation.Min(c => c.Fitness);
        public int AverageFitness() => (int)parentPopulation.Average(c => c.Fitness);
        public Chromosome GetBestChromosome()
        {
            return parentPopulation.OrderBy(ch => ch.Fitness).First();
        }
    }
}
