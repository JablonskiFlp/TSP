using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSP.Models;

namespace TSP.Services
{
    public static class CsvSaver
    {
        public static void SaveToCsv(CurrentState state, Settings settings, bool isQuick)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(settings.SavePath))
                {
                    string folder = AppDomain.CurrentDomain.BaseDirectory;
                    settings.SavePath = Path.Combine(folder, "wyniki.csv");
                }

                bool addHeader = !File.Exists(settings.SavePath) || IsReallyEmpty(settings.SavePath);

                using StreamWriter sw = new StreamWriter(settings.SavePath, append: true);
                if (addHeader)
                {
                    sw.WriteLine("PopulationID,Czas,Generacje,Stagnacja,OstatniaGeneracja,Fitness,LiczbaMiast,IloscChromosomow,Selekcja,Krzyżowanie,Mutacja,ProcentRodzicow,ProcentMutacji,ProcentKrzyzowania,IsQuick");
                }

                Chromosome best = state.Population.GetBestChromosome();
                double czas =  (DateTime.Now - state.StartTime).TotalSeconds;

                string linia = string.Join(",",
                    state.Population.populationID,
                    czas.ToString(CultureInfo.InvariantCulture),
                    settings.Generations,
                    settings.StagnationLimit,
                    state.LastGeneration,
                    state.BestFitness,
                    state.Population.baseChromosome.numberOfGenes,
                    state.Population.numberOfChromosomes,
                    settings.SelectionType,
                    settings.CrossoverType,
                    settings.MutationType,
                    settings.ParentRatio.ToString(CultureInfo.InvariantCulture),
                    settings.MutationRatio.ToString(CultureInfo.InvariantCulture),
                    settings.CrossoverRatio.ToString(CultureInfo.InvariantCulture),
                    isQuick
                );

                sw.WriteLine(linia);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd zapisu pliku: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static bool IsReallyEmpty(string path)
        {
            if (!File.Exists(path))
                return true;

            string content = File.ReadAllText(path).Trim();
            return string.IsNullOrEmpty(content);
        }
    }
}
