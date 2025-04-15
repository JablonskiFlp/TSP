using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP.Models
{
    public class Chromosome
    {
        public List<Gene> genes = new List<Gene>();
        private static Random rand = new Random();
        private static int[,] _distanceMatrix;
        private int _numberOfGenes;
        public int Fitness;

        public Chromosome(int numberOfGenes)
        {
            _numberOfGenes = numberOfGenes;
            createBaseChromosome();
            CreateDistanceMatrix();


        }
        private void createBaseChromosome()
        {
            for (int i = 0; i < _numberOfGenes; i++)
            {
                genes.Add(new Gene(rand.Next(0, 100), rand.Next(0, 100), "City" + i, i));
            }
        }
        private void CreateDistanceMatrix()
        {
            _distanceMatrix = new int[_numberOfGenes, _numberOfGenes];

            for (int i = 0; i < _numberOfGenes; i++)
            {
                for (int j = 0; j < _numberOfGenes; j++)
                {
                    _distanceMatrix[i, j] = Gene.CalculateDistance(genes[i], genes[j]);
                }
            }
        }

        public Chromosome Shuffle()
        {
            List<Gene> shuffledGenes = genes.Skip(1).OrderBy(g => rand.Next()).ToList();
            List<Gene> newGenes = new List<Gene> { genes.First() };
            newGenes.AddRange(shuffledGenes);
            Chromosome newchrom = new Chromosome(newGenes);
            return newchrom;
        }

        public Chromosome(List<Gene> genes)
        {
            _numberOfGenes = genes.Count;
            this.genes = new List<Gene>(genes);
            this.addFitness();
        }

        private int calculateFitness()
        {
            int fitness = 0;
            for (int i = 0; i < _numberOfGenes - 1; i++)
            {
                fitness += _distanceMatrix[genes[i].Position, genes[i + 1].Position];
            }
            fitness += _distanceMatrix[genes[_numberOfGenes - 1].Position, genes[0].Position];
            return fitness;
        }
        public void addFitness()
        {
            Fitness = calculateFitness();
        }
        public void PrintChromosome()
        {
            Console.WriteLine(string.Join(" -> ", genes.Select(g => g.Position)));
        }
    }
}
