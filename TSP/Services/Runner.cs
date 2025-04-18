using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSP.Models;
using static System.Windows.Forms.AxHost;

namespace TSP.Services
{
    public class Runner
    {
        private readonly Settings _settings;
        private readonly CurrentState _state;

        public Runner(Settings settings, CurrentState state)
        {
            _settings = settings;
            _state = state;
        }

        public async Task RunAsync(CancellationToken token, Action<int, int> updateUi)
        {
            for (int i = 0; i < _settings.Generations; i++)
            {
                if (token.IsCancellationRequested) break;
                while (_state.IsPaused) await Task.Delay(100);

                _state.Population.createNextPopulation(
                    _settings.SelectionType, _settings.CrossoverType, _settings.MutationType,
                    _settings.ParentRatio, _settings.CrossoverRatio, _settings.MutationRatio
                );

                int currentBest = _state.Population.BestFitness();
                int currentAvg = _state.Population.AverageFitness();
                _state.BestFitnessHistory.Add(currentBest);
                _state.AverageFitnessHistory.Add(currentAvg);

                if (currentBest < _state.BestFitness)
                {
                    _state.BestFitness = currentBest;
                    _state.StagnationCounter = 0;
                }
                else
                {
                    _state.StagnationCounter++;
                }

                updateUi?.Invoke(i + 1, currentBest);

                if (_state.StagnationCounter >= _settings.StagnationLimit)
                {
                    if (!_state.QuickEnd)
                    {
                        updateUi?.Invoke(i + 1, currentBest);
                    }
                        _state.LastGeneration = i;
                    CsvSaver.SaveToCsv(_state, _settings, false);
                    return;
                }

                if (!_state.QuickEnd)
                {
                    await Task.Delay(501 - _state.Speed);
                }
            }

            _state.LastGeneration = _settings.Generations;
            CsvSaver.SaveToCsv(_state, _settings, false);
        }

        private void RunQuick(CancellationToken token)
        {
            for (int i = 0; i < _settings.Generations; i++)
            {
                if (token.IsCancellationRequested)
                    break;

                _state.Population.createNextPopulation(
                    _settings.SelectionType,
                    _settings.CrossoverType,
                    _settings.MutationType,
                    _settings.ParentRatio,
                    _settings.CrossoverRatio,
                    _settings.MutationRatio
                );

                int currentBest = _state.Population.BestFitness();

                if (currentBest < _state.BestFitness)
                {
                    _state.BestFitness = currentBest;
                    _state.StagnationCounter = 0;
                }
                else
                {
                    _state.StagnationCounter++;
                }

                if (_state.StagnationCounter >= _settings.StagnationLimit)
                {
                    _state.LastGeneration = i;
                    CsvSaver.SaveToCsv(_state, _settings, true);
                    return;
                }
            }

            _state.LastGeneration = _settings.Generations;
            CsvSaver.SaveToCsv(_state, _settings, true);
        }

        public async Task RunQuickAsync(CancellationToken token)
        {
            await Task.Run(() => RunQuick(token), token);
        }
    }
}
