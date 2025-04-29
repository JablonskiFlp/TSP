using TSP.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TSP.Operations
{
    public static class Crossovers
    {
        public static List<Chromosome> ApplyCrossover(List<Chromosome> parents, string crossoverType, double crossoverRate)
        {
            List<Chromosome> offspring = new List<Chromosome>();
            Random rand = new Random();

            for (int i = 0; i < parents.Count - 1; i += 2)
            {
                if (rand.NextDouble() <= crossoverRate)
                {
                    switch (crossoverType.ToLower())
                    {
                        case "porządkowe":
                            offspring.AddRange(OrderCrossover(parents[i], parents[i + 1]));
                            break;
                        case "częściowo odwz.":
                            offspring.AddRange(PartiallyMappedCrossover(parents[i], parents[i + 1]));
                            break;
                        default:
                            throw new ArgumentException("Invalid crossover type");
                    }
                }
                else
                {
                    offspring.Add(parents[i]);
                    offspring.Add(parents[i + 1]);
                }
            }

            if (parents.Count % 2 != 0)
            {
                offspring.Add(parents[^1]); 
            }
            return offspring;
        }

        private static List<Chromosome> OrderCrossover(Chromosome parent1, Chromosome parent2)
        {
            List<Chromosome> offspring = new List<Chromosome>();
            Random rand = new Random();
            int size = parent1.genes.Count;

            int start = rand.Next(size);
            int end = rand.Next(start, size);

            List<Gene> childGenes1 = new List<Gene>(new Gene[size]);
            List<Gene> childGenes2 = new List<Gene>(new Gene[size]);

            for (int j = start; j < end; j++)
            {
                childGenes1[j] = parent1.genes[j];
                childGenes2[j] = parent2.genes[j];
            }

            FillRemainingGenes(parent2, childGenes1, start, end);
            FillRemainingGenes(parent1, childGenes2, start, end);

            offspring.Add(new Chromosome(childGenes1));
            offspring.Add(new Chromosome(childGenes2));
            return offspring;
        }

        private static void FillRemainingGenes(Chromosome parent, List<Gene> childGenes, int start, int end)
        {
            int size = parent.genes.Count;
            int index = end % size;

            foreach (var gene in parent.genes)
            {
                if (!childGenes.Contains(gene))
                {
                    childGenes[index] = gene;
                    index = (index + 1) % size;
                }
            }
        }

        private static List<Chromosome> PartiallyMappedCrossover(Chromosome parent1, Chromosome parent2)
        {
            List<Chromosome> offspring = new List<Chromosome>();
            Random rand = new Random();
            int size = parent1.genes.Count;

            int start = rand.Next(size - 1);
            int end = rand.Next(start + 1, size);

            List<Gene> childGenes1 = Enumerable.Repeat<Gene>(null, size).ToList();
            List<Gene> childGenes2 = Enumerable.Repeat<Gene>(null, size).ToList();

            for (int j = start; j < end; j++)
            {
                childGenes1[j] = parent2.genes[j];
                childGenes2[j] = parent1.genes[j];
            }

            FillPMX(parent1, parent2, childGenes1, start, end);
            FillPMX(parent2, parent1, childGenes2, start, end);

            offspring.Add(new Chromosome(childGenes1));
            offspring.Add(new Chromosome(childGenes2));
            return offspring;
        }

        private static void FillPMX(Chromosome parent1, Chromosome parent2, List<Gene> childGenes, int start, int end)
        {
            var mapping = parent1.genes.Skip(start).Take(end - start).Zip(parent2.genes.Skip(start).Take(end - start), (p1, p2) => (p1, p2))
                                        .ToDictionary(x => x.p1, x => x.p2);
            var visited = new HashSet<Gene>();

            for (int i = 0; i < childGenes.Count; i++)
            {
                if (childGenes[i] != null) continue;

                Gene gene = parent1.genes[i];
                while (mapping.TryGetValue(gene, out Gene mappedGene) && visited.Add(gene))
                    gene = mappedGene;

                if (!childGenes.Contains(gene))
                    childGenes[i] = gene;
            }

            foreach (var gene in parent1.genes)
                if (!childGenes.Contains(gene))
                    childGenes[childGenes.IndexOf(null)] = gene;
        }
    }
}
