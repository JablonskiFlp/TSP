using TSP.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TSP.Operations
{
    public static class Mutations
    {
        public static List<Chromosome> ApplyMutation(List<Chromosome> population, string mutationType, double mutationRatio)
        {
            List<Chromosome> mutatedPopulation = new List<Chromosome>();
            Random rand = new Random();

            foreach (var chrom in population)
            {
                if (rand.NextDouble() <= mutationRatio)
                {
                    switch (mutationType.ToLower())
                    {
                        case "zamiana miejsc":
                            mutatedPopulation.Add(SwapMutation(chrom, rand));
                            break;
                        case "przetasowanie":
                            mutatedPopulation.Add(ScrambleMutation(chrom, rand));
                            break;
                        default:
                            throw new ArgumentException("Invalid mutation type");
                    }
                }
                else
                {
                    mutatedPopulation.Add(chrom);
                }
            }
            return mutatedPopulation;
        }

        private static Chromosome SwapMutation(Chromosome chrom, Random rand)
        {
            List<Gene> newGenes = new List<Gene>(chrom.genes);
            int index1 = rand.Next(newGenes.Count);
            int index2 = rand.Next(newGenes.Count);
            (newGenes[index1], newGenes[index2]) = (newGenes[index2], newGenes[index1]);

            return new Chromosome(newGenes);
        }

        private static Chromosome ScrambleMutation(Chromosome chrom, Random rand)
        {
            List<Gene> newGenes = new List<Gene>(chrom.genes);
            int start = rand.Next(newGenes.Count);
            int end = rand.Next(start, newGenes.Count);

            List<Gene> scrambledSegment = newGenes.Skip(start).Take(end - start).OrderBy(_ => rand.Next()).ToList();
            newGenes.RemoveRange(start, end - start);
            newGenes.InsertRange(start, scrambledSegment);

            return new Chromosome(newGenes);
        }
    }
}
