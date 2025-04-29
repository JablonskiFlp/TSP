using TSP.Models;
using TSP.Services;
using static System.Windows.Forms.AxHost;

namespace TSP;

public partial class TSP : Form
{
    public DateTime startTime;
    private Settings settings = new Settings();
    private CurrentState state = new CurrentState();
    private Runner algorithmRunner;
    private CancellationToken token;
    public TSP()
    {
        InitializeComponent();
        this.AutoScaleMode = AutoScaleMode.None;
    }

    private async void btnStart_Click(object sender, EventArgs e)
    {
        try
        {
            settings.txtCityCount = int.Parse(txtCityCount.Text);
            settings.numChromosomes = int.Parse(txtNumPop.Text);
            token = new();
            if (!InitializeSettings())
            {
                btnStart.Enabled = true;
                return;
            }

            if (settings.txtCityCount < 3)
            {
                MessageBox.Show("Liczba miast musi byæ wiêksza ni¿ 2!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnStart.Enabled = true;
                return;
            }
            state.QuickEnd = false;
            btnStart.Enabled = false;
            state.QuickEndWithoutProceeding = false;
            if (chkUseSamePopulation.Checked && state.Population != null && state.Population.baseChromosome.numberOfGenes == settings.txtCityCount)
            {
                state.Population.resetPopulation();
                state.Population.ChangeNumberOfChromosomes(settings.numChromosomes);
            }
            else
            {
                state.Population = new Population(settings.numChromosomes, settings.txtCityCount);
            }
            lblInfo.Visible = true;
            algorithmRunner = new Runner(settings, state);
            if (chkSkipVisualisation.Checked)
            {
                await RunWithoutVisualization();
            }
            else
            {
                await RunWithVisualization();
            }
            lblInfo.Visible = false;
            btnStart.Enabled = true;
        }
        catch (FormatException)
        {
            MessageBox.Show("Nieprawid³owy format danych wejœciowych!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnStart.Enabled = true;
            return;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Wyst¹pi³ b³¹d: {ex.Message}", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnStart.Enabled = true;
            return;
        }
    }

    public void DrawChart()
    {
        chartBox2.Image?.Dispose();
        chartBox2.Image = Drawer.DrawChart(state.BestFitnessHistory, state.AverageFitnessHistory, chartBox2.Width, chartBox2.Height);
    }

    private void DrawBestChromosome()
    {
        pictureBox.Image?.Dispose();
        pictureBox.Image = Drawer.DrawChromosome(state.Population.GetBestChromosome(), pictureBox.Width, pictureBox.Height);
    }
    private void TSP_Load(object sender, EventArgs e)
    {
        cmbCrossover.SelectedIndex = 0;
        cmbMutation.SelectedIndex = 0;
        cmbSelection.SelectedIndex = 0;
    }

    private void btnPause_Click(object sender, EventArgs e)
    {
        state.IsPaused = true;
    }

    private void chkSkipVisualisation_CheckedChanged(object sender, EventArgs e)
    {
        bool isChecked = chkSkipVisualisation.Checked;
        lblRepeatCount.Visible = isChecked;
        txtRepeatCount.Visible = isChecked;
        button1.Visible = !isChecked;
    }

    private void btnResume_Click(object sender, EventArgs e)
    {
        state.IsPaused = false;
    }

    private async Task RunWithoutVisualization()
    {
        int repeatCount = 1;
        int.TryParse(txtRepeatCount.Text, out repeatCount);
        for (int i = 0; i < repeatCount; i++)
        {
            state.StagnationCounter = 0;
            state.BestFitness = int.MaxValue;
            state.StartTime = DateTime.Now;
            if (chkUseSamePopulation.Checked && state.Population != null)
                state.Population.resetPopulation();
            else
                state.Population = new Population(settings.numChromosomes, settings.txtCityCount);

            await algorithmRunner.RunQuickAsync(token);
        }
        DrawBestChromosome();
        if(state.QuickEndWithoutProceeding)
        {
            MessageBox.Show("Algorytm zosta³ przerwany przez u¿ytkownika.", "Koniec");
            return;
        }
        else
        {
            MessageBox.Show($"Algorytm wykonany zosta³ {repeatCount} razy, wyniki zosta³y zapisane do pliku.", "Koniec");
        }

        lblIteration.Text = $"Iteracja: {state.LastGeneration + 1}";
        lblBestFitness.Text = $"Najlepszy Fitness: {state.Population.BestFitness()}";
    }
    private async Task RunWithVisualization()
    {
        await algorithmRunner.RunAsync(token, (iteration, bestFitness) =>
        {
            lblIteration.Invoke((MethodInvoker)(() => lblIteration.Text = $"Iteracja: {iteration}"));
            lblBestFitness.Invoke((MethodInvoker)(() => lblBestFitness.Text = $"Najlepszy Fitness: {bestFitness}"));
            DrawChart();
            DrawBestChromosome();
        });
        if (state.QuickEndWithoutProceeding)
        {
            MessageBox.Show("Algorytm zosta³ przerwany przez u¿ytkownika.", "Koniec");
            return;
        }
        {
            MessageBox.Show("To jest najlepsze rozwi¹zanie jakie uda³o siê znaleŸæ. Wyniki zosta³y zapisane do pliku.", "Koniec");
        }
    }
    private bool InitializeSettings()
    {
        try
        {
            settings.Generations = int.TryParse(txtGenerations.Text, out int gens) ? gens : 1000;
            settings.StagnationLimit = int.TryParse(txtStagnation.Text, out int stagnation) ? stagnation : 100;
            settings.ParentRatio = double.Parse(txtParentRatio.Text) / 100;
            settings.MutationRatio = double.Parse(txtMutationPercent.Text) / 100;
            settings.CrossoverRatio = double.Parse(txtCrossoverPercent.Text) / 100;

            settings.SelectionType = cmbSelection.SelectedItem?.ToString() ?? "Tournament";
            settings.CrossoverType = cmbCrossover.SelectedItem?.ToString() ?? "OX1";
            settings.MutationType = cmbMutation.SelectedItem?.ToString() ?? "Swap";

            state.StartTime = DateTime.Now;
            state.StagnationCounter = 0;
            state.BestFitness = int.MaxValue;
            state.LastGeneration = 0;
            state.BestFitnessHistory.Clear();
            state.AverageFitnessHistory.Clear();
            state.IsPaused = false;

            return true;
        }
        catch (FormatException)
        {
            MessageBox.Show("Nieprawid³owy format danych wejœciowych!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    private void btnSaveFile_Click(object sender, EventArgs e)
    {
        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        {
            saveFileDialog.Title = "Wybierz miejsce do zapisu wyników";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                settings.SavePath = saveFileDialog.FileName;
            }
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        state.QuickEnd = true;
    }

    private void test(object sender, EventArgs e)
    {
        state.Speed = TrackBar.Value;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        state.QuickEndWithoutProceeding = true;
    }
}

