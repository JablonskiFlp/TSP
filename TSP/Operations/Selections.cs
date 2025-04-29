using TSP.Models;

namespace TSP.Operations
{
    public static class Selections
    {
        public static List<Chromosome> Select(List<Chromosome> population, string selectionType)
        {
            int tournamentSize = (int)Math.Max(2, Math.Sqrt(population.Count));
            switch (selectionType.ToLower())
            {
                case "ruletkowa":
                    return RouletteSelection(population);
                case "turniejowa":
                    return TournamentSelection(population, tournamentSize);
                case "rankingowa":
                    return RankSelection(population);
                default:
                    throw new ArgumentException("Invalid selection type");
            }
        }

        private static List<Chromosome> RouletteSelection(List<Chromosome> population)
        {
            List<Chromosome> selected = new List<Chromosome>();
            Random rand = new Random();  

            double totalFitness = population.Sum(c => 1.0 / c.Fitness);

            for (int i = 0; i < population.Count; i++) 
            {
                double pick = rand.NextDouble() * totalFitness;
                double sum = 0;

                foreach (var chrom in population)
                {
                    sum += 1.0 / chrom.Fitness; 
                    if (sum >= pick)
                    {
                        selected.Add(chrom);
                        break;
                    }
                }
            }

            return selected;
        }
        private static List<Chromosome> TournamentSelection(List<Chromosome> population, int tournamentSize)
        {
            List<Chromosome> selected = new List<Chromosome>();
            Random rand = new Random();

            for (int i = 0; i < population.Count; i++)
            {
                var tournament = population.OrderBy(x => rand.Next()).Take(tournamentSize).ToList();
                selected.Add(tournament.OrderBy(c => c.Fitness).First());
            }
            return selected;
        }

        private static List<Chromosome> RankSelection(List<Chromosome> population)
        {
            List<Chromosome> selected = new List<Chromosome>();
            Random rand = new Random();

            var rankedPopulation = population.OrderBy(c => c.Fitness).ToList();
            int n = rankedPopulation.Count;

            double total = (n * (n + 1)) / 2.0; 
            var probabilities = new double[n];

            for (int i = 0; i < n; i++)
            {
                probabilities[i] = (n - i) / total; 
            }

            for (int i = 0; i < population.Count; i++)
            {
                double r = rand.NextDouble();
                double cumulative = 0.0;

                for (int j = 0; j < n; j++)
                {
                    cumulative += probabilities[j];
                    if (r <= cumulative)
                    {
                        selected.Add(rankedPopulation[j]);
                        break;
                    }
                }
            }

            return selected;
        }
    }
}
