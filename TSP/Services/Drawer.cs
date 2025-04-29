using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSP.Models;

namespace TSP.Services
{
    public static class Drawer
    {
        public static Bitmap DrawChart(List<int> bestFitnessHistory, List<int> averageFitnessHistory, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            if (bestFitnessHistory.Count < 2) return bmp;

            Pen bestPen = new Pen(Color.Green, 2);
            Pen avgPen = new Pen(Color.Blue, 2);

            int padding = 20;
            int graphWidth = width - 2 * padding;
            int graphHeight = height - 2 * padding;

            int maxIterations = bestFitnessHistory.Count;
            int maxFitness = Math.Max(bestFitnessHistory.Max(), averageFitnessHistory.Max());

            float scaleX = (float)graphWidth / maxIterations;
            float scaleY = (float)graphHeight / maxFitness;

            for (int i = 1; i < maxIterations; i++)
            {
                g.DrawLine(bestPen,
                    padding + (i - 1) * scaleX, height - padding - bestFitnessHistory[i - 1] * scaleY,
                    padding + i * scaleX, height - padding - bestFitnessHistory[i] * scaleY);

                g.DrawLine(avgPen,
                    padding + (i - 1) * scaleX, height - padding - averageFitnessHistory[i - 1] * scaleY,
                    padding + i * scaleX, height - padding - averageFitnessHistory[i] * scaleY);
            }

            return bmp;
        }

        public static Bitmap DrawChromosome(Chromosome best, int width, int height, int scale = 5)
        {
            Bitmap bmp = new Bitmap(width, height);
            using Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 2);
            Brush brush = new SolidBrush(Color.Red);

            for (int i = 0; i < best.genes.Count; i++)
            {
                Gene g1 = best.genes[i];
                Gene g2 = best.genes[(i + 1) % best.genes.Count];
                g.DrawLine(pen, g1.X * scale, g1.Y * scale, g2.X * scale, g2.Y * scale);
            }

            foreach (var gene in best.genes)
            {
                g.FillEllipse(brush, gene.X * scale - 3, gene.Y * scale - 3, 6, 6);
            }

            return bmp;
        }
    }
}