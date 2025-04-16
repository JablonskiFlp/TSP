using System.Globalization;
using System.IO;
using TSP.Models;

namespace TSP;

public partial class TSP : Form
{
    private Population population;
    private int generations;
    private int stagnationLimit;
    private int stagnationCounter;
    private int bestFitness;
    private string selectionType;
    private string crossoverType;
    private string mutationType;
    public double PartentRatio;
    public double CrossoverRatio;
    public double MutationRatio;
    private bool isPaused = false;
    private CancellationTokenSource cts;
    private Label lblIteration;
    public TrackBar trackSpeed;
    private CheckBox chkSkipVisualization;
    private Label lblProgress;
    public PictureBox chartBox;
    public PictureBox pictureBox;
    private List<int> bestFitnessHistory = new List<int>();
    private List<int> averageFitnessHistory = new List<int>();
    public Label lblBestFitness;
    private Label lblfit;
    public DateTime startTime;
    private int _lastGeneration;
    private string txtSciezka;
    private Button btnUstawSciezke;

    public TSP()
    {
        InitializeComponent();
        InitializeUI();
    }

    private void InitializeUI()
    {
        this.Text = "Problem Komiwoja¿era";
        this.Size = new Size(660, 800);

        Label lblPopSize = new Label() { Text = "Rozmiar populacji:", Location = new Point(20, 20), AutoSize = true };
        TextBox txtPopSize = new TextBox() { Location = new Point(150, 20), Width = 50, Text = "10" };

        Label lblNumPop = new Label() { Text = "Liczba pokoleñ:", Location = new Point(20, 50), AutoSize = true };
        TextBox txtNumPop = new TextBox() { Location = new Point(150, 50), Width = 50, Text = "10" };

        Label lblGenerations = new Label() { Text = "Maks. generacje:", Location = new Point(20, 80), AutoSize = true };
        TextBox txtGenerations = new TextBox() { Location = new Point(150, 80), Width = 50, Text = "100" };

        Label lblStagnation = new Label() { Text = "Limit stagnacji:", Location = new Point(20, 110), AutoSize = true };
        TextBox txtStagnation = new TextBox() { Location = new Point(150, 110), Width = 50, Text = "20" };

        Label lblPercent = new Label() { Text = "Prawdopodobieñstwo kry¿owania:", Location = new Point(20, 140), AutoSize = true };
        Label lblMutationPercent = new Label() { Text = "mutacji:", Location = new Point(285, 140), AutoSize = true };

        TextBox txtCrossoverPercent = new TextBox() { Location = new Point(220, 140), Width = 50, Text = "90" };
        TextBox txtMutationPercent = new TextBox() { Location = new Point(380, 140), Width = 70, Text = "10" };

        Label lblSelection = new Label() { Text = "Selekcja:", Location = new Point(250, 20), AutoSize = true };
        ComboBox cmbSelection = new ComboBox() { Location = new Point(330, 20), Width = 120 };
        cmbSelection.Items.AddRange(new string[] { "ruletkowa", "turniejowa", "rankingowa" });
        cmbSelection.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbSelection.SelectedIndex = 0;

        Label lblCrossover = new Label() { Text = "Krzy¿owanie:", Location = new Point(250, 50), AutoSize = true };
        ComboBox cmbCrossover = new ComboBox() { Location = new Point(330, 50), Width = 120 };
        cmbCrossover.Items.AddRange(new string[] { "porz¹dkowe ", "czêœciowo odwz." });
        cmbCrossover.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCrossover.SelectedIndex = 0;

        Label lblMutation = new Label() { Text = "Mutacja:", Location = new Point(250, 80), AutoSize = true };
        ComboBox cmbMutation = new ComboBox() { Location = new Point(330, 80), Width = 120 };
        cmbMutation.Items.AddRange(new string[] { "zamiana miejsc", "przetasowanie" });
        cmbMutation.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbMutation.SelectedIndex = 0;

        Label lblParentRation = new Label() { Text = "Procent rodziców", Location = new Point(250, 110), AutoSize = true };
        TextBox txtParentRation = new TextBox() { Location = new Point(380, 110), Width = 70, Text = "50" };

        lblIteration = new Label() { Text = "Iteracja: 0", Location = new Point(300, 730), AutoSize = true };

        Button btnStart = new Button() { Text = "Start", Location = new Point(20, 170), Width = 100 };
        Button btnPause = new Button() { Text = "Pauza", Location = new Point(130, 170), Width = 100 };
        Button btnResume = new Button() { Text = "Wznów", Location = new Point(240, 170), Width = 100 };

        btnUstawSciezke = new Button();
        btnUstawSciezke.Text = "Ustaw œcie¿kê zapisu";
        btnUstawSciezke.Location = new Point(440, 725);
        btnUstawSciezke.Click += BtnUstawSciezke_Click;
        btnUstawSciezke.Width = 180;
        this.Controls.Add(btnUstawSciezke);

        btnPause.Click += (sender, args) => isPaused = true;
        btnResume.Click += (sender, args) => isPaused = false;

        lblfit = new Label() { Text = "Wykres mediany \n i œredniej fitness: ", Location = new Point(470, 20), AutoSize = true };
        chartBox = new PictureBox() { Location = new Point(20, 220), Size = new Size(600, 500), BorderStyle = BorderStyle.FixedSingle, BackColor = Color.White };
        pictureBox = new PictureBox
        {
            Location = new Point(470, 50),
            Size = new Size(150, 100),
            BorderStyle = BorderStyle.FixedSingle,
            BackColor = Color.White
        };

        lblProgress = new Label() { Text = "Prêdkoœæ: ", Location = new Point(350, 175), AutoSize = true };
        trackSpeed = new TrackBar() { Minimum = 1, Maximum = 500, Value = 250, TickFrequency = 100, Location = new Point(420, 170), Width = 200 };

        CheckBox chkUseSamePopulation = new CheckBox()
        {
            Text = "U¿yj tej samej populacji pocz¹tkowej",
            Location = new Point(20, 200),
            AutoSize = true,
            Checked = true
        };

        chkSkipVisualization = new CheckBox() { Text = "Tylko wynik", Location = new Point(250, 200), AutoSize = true };
        lblBestFitness = new Label
        {
            Location = new Point(20, 730),
            AutoSize = true,
            Text = "Najlepszy obecnie fitness: -"
        };

        Label lblRepeatCount = new Label()
        {
            Text = "Liczba symulacji:",
            Location = new Point(380, 200),
            AutoSize = true,
            Visible = false // <-- ukryty na start
        };

        TextBox txtRepeatCount = new TextBox()
        {
            Location = new Point(500, 195),
            Width = 50,
            Text = "1",
            Visible = false // <-- ukryty na start
        };

        chkSkipVisualization.CheckedChanged += (sender, args) =>
        {
            bool isChecked = chkSkipVisualization.Checked;
            lblRepeatCount.Visible = isChecked;
            txtRepeatCount.Visible = isChecked;
        };

        btnStart.Click += async (sender, args) =>
        {
            try {
                DateTime startTime = DateTime.Now;
                btnStart.Enabled = false;
                int populationSize = int.Parse(txtPopSize.Text);
                int numPopulations = int.Parse(txtNumPop.Text);
                generations = int.Parse(txtGenerations.Text);
                stagnationLimit = int.Parse(txtStagnation.Text);
                PartentRatio = double.Parse(txtParentRation.Text) / 100;
                MutationRatio = double.Parse(txtMutationPercent.Text) / 100;
                CrossoverRatio = double.Parse(txtCrossoverPercent.Text) / 100;
                stagnationCounter = 0;
                bestFitness = int.MaxValue;
                selectionType = cmbSelection.SelectedItem.ToString();
                crossoverType = cmbCrossover.SelectedItem.ToString();
                mutationType = cmbMutation.SelectedItem.ToString();

                if (chkUseSamePopulation.Checked && population != null)
                {
                    population.resetPopulation();
                }
                else
                {
                    population = new Population(numPopulations, populationSize);
                }

                cts = new CancellationTokenSource();
                if (chkSkipVisualization.Checked)
                {
                    int repeatCount = 1;
                    int.TryParse(txtRepeatCount.Text, out repeatCount);
                    for (int i = 0; i < repeatCount; i++)
                    {
                        stagnationCounter = 0;
                        bestFitness = int.MaxValue;

                        if (chkUseSamePopulation.Checked)
                            population.resetPopulation();
                        else
                            population = new Population(numPopulations, populationSize);
                        RunAnlgorithmQuick();
                    }
                    DrawBestChromosome();
                    MessageBox.Show($"Algorytm wykonany zosta³ {txtRepeatCount.Text} razy, wyniki zosta³y zapisane do pliku.", "Koniec");
                    lblIteration.Text = $"Iteracja: {_lastGeneration + 1}";
                    lblBestFitness.Text = $"Najlepszy Fitness: {population.BestFitness()}";
                }
                else
                {
                    await RunAlgorithm(cts.Token);
                }
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



        };
        this.Controls.Add(lblRepeatCount);
        this.Controls.Add(txtRepeatCount);
        this.Controls.Add(txtCrossoverPercent);
        this.Controls.Add(lblMutationPercent);
        this.Controls.Add(txtMutationPercent);
        this.Controls.Add(lblPercent);
        this.Controls.Add(lblBestFitness);
        this.Controls.Add(chartBox);
        this.Controls.Add(chkSkipVisualization);
        this.Controls.Add(lblProgress);
        this.Controls.Add(chkUseSamePopulation);
        this.Controls.Add(lblParentRation);
        this.Controls.Add(txtParentRation);
        this.Controls.Add(lblPopSize);
        this.Controls.Add(txtPopSize);
        this.Controls.Add(lblNumPop);
        this.Controls.Add(txtNumPop);
        this.Controls.Add(lblGenerations);
        this.Controls.Add(txtGenerations);
        this.Controls.Add(lblStagnation);
        this.Controls.Add(txtStagnation);
        this.Controls.Add(lblSelection);
        this.Controls.Add(cmbSelection);
        this.Controls.Add(lblCrossover);
        this.Controls.Add(cmbCrossover);
        this.Controls.Add(lblMutation);
        this.Controls.Add(cmbMutation);
        this.Controls.Add(lblIteration);
        this.Controls.Add(btnStart);
        this.Controls.Add(btnPause);
        this.Controls.Add(btnResume);
        this.Controls.Add(pictureBox);
        this.Controls.Add(trackSpeed);
        this.Controls.Add(lblfit);
    }

    private async Task RunAlgorithm(CancellationToken token)
    {
        for (int i = 0; i < generations; i++)
        {
            if (token.IsCancellationRequested) break;
            while (isPaused) await Task.Delay(100);

            population.createNextPopulation(selectionType, crossoverType, mutationType, PartentRatio, CrossoverRatio, MutationRatio);

            int currentBest = population.BestFitness();
            int currentAvg = population.AverageFitness();
            bestFitnessHistory.Add(currentBest);
            averageFitnessHistory.Add(currentAvg);
            if (currentBest < bestFitness)
            {
                bestFitness = currentBest;
                stagnationCounter = 0;
            }
            else stagnationCounter++;

            lblIteration.Invoke((MethodInvoker)(() => lblIteration.Text = $"Iteracja: {i + 1}"));
            lblBestFitness.Invoke((MethodInvoker)(() => lblBestFitness.Text = $"Najlepszy Fitness: {currentBest}"));

            DrawChart();

            DrawBestChromosome();
            if (stagnationCounter >= stagnationLimit)
            {
                _lastGeneration = i;
                ZapiszDoCSV();
                MessageBox.Show("To jest najlepsze rozwi¹zanie jakie uda³o siê znaleœæ. Wyniki zosta³y zapisane do pliku.", "Koniec");
                return;
            }

            await Task.Delay(501 - trackSpeed.Value);
        }
        _lastGeneration = generations;
        ZapiszDoCSV();
        MessageBox.Show("To jest najlepsze rozwi¹zanie jakie uda³o siê znaleœæ. Wyniki zosta³y zapisane do pliku.", "Koniec");
        return;
    }

    private void RunAnlgorithmQuick()
    {
        for (int i = 0; i < generations; i++)
        {
            population.createNextPopulation(selectionType, crossoverType, mutationType, PartentRatio, CrossoverRatio, MutationRatio);
            int currentBest = population.BestFitness();
            if (currentBest < bestFitness)
            {
                bestFitness = currentBest;
                stagnationCounter = 0;
            }
            else stagnationCounter++;
            if (stagnationCounter >= stagnationLimit)
            {
                _lastGeneration = i;
                ZapiszDoCSV();
                return;
            }
        }
        _lastGeneration = generations;
        ZapiszDoCSV();
    }

    private void DrawChart()
    {
        if (pictureBox.Image != null) pictureBox.Image.Dispose();
        Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
        using (Graphics g = Graphics.FromImage(bmp))
        {
            g.Clear(Color.White);
            Pen bestPen = new Pen(Color.Green, 2);
            Pen avgPen = new Pen(Color.Blue, 2);

            int padding = 20;
            int graphWidth = bmp.Width - 2 * padding;
            int graphHeight = bmp.Height - 2 * padding;

            if (bestFitnessHistory.Count > 1)
            {
                int maxIterations = bestFitnessHistory.Count;
                int maxFitness = Math.Max(bestFitnessHistory.Max(), averageFitnessHistory.Max());
                float scaleX = (float)graphWidth / maxIterations;
                float scaleY = (float)graphHeight / maxFitness;

                for (int i = 1; i < maxIterations; i++)
                {
                    g.DrawLine(bestPen,
                        padding + (i - 1) * scaleX, bmp.Height - padding - bestFitnessHistory[i - 1] * scaleY,
                        padding + i * scaleX, bmp.Height - padding - bestFitnessHistory[i] * scaleY);

                    g.DrawLine(avgPen,
                        padding + (i - 1) * scaleX, bmp.Height - padding - averageFitnessHistory[i - 1] * scaleY,
                        padding + i * scaleX, bmp.Height - padding - averageFitnessHistory[i] * scaleY);
                }
            }
        }
        pictureBox.Image = bmp;
    }
    private void DrawBestChromosome()
    {
        Chromosome best = population.GetBestChromosome();
        if (chartBox == null) return;

        Bitmap bmp = new Bitmap(chartBox.Width, chartBox.Height);
        Graphics g = Graphics.FromImage(bmp);
        g.Clear(Color.White);

        Pen pen = new Pen(Color.Blue, 2);
        Brush brush = new SolidBrush(Color.Red);

        int scale = 5;
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

        chartBox.Invoke((MethodInvoker)(() => chartBox.Image = bmp));
    }

    private void BtnUstawSciezke_Click(object sender, EventArgs e)
    {
        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        {
            saveFileDialog.Title = "Wybierz miejsce do zapisu wyników";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtSciezka = saveFileDialog.FileName;
            }
        }
    }

    private void ZapiszDoCSV()
    {
        try
        {
            // Jeœli nie ustawiono œcie¿ki, ustaw domyœln¹ w katalogu aplikacji
            if (string.IsNullOrWhiteSpace(txtSciezka))
            {
                string folder = AppDomain.CurrentDomain.BaseDirectory;
                txtSciezka = Path.Combine(folder, $"wyniki.csv");
            }

            bool addHeader = false;

            if (!File.Exists(txtSciezka) || new FileInfo(txtSciezka).Length == 0)
            {
                addHeader = true;
            }

            using (StreamWriter sw = new StreamWriter(txtSciezka, append: true))
            {
                if (addHeader)
                {
                    sw.WriteLine("PopulationID,Czas,Generacje,Stagnacja,OstatniaGeneracja,Fitness,Populacja,Geny,Selekcja,Krzy¿owanie,Mutacja,ProcentRodzicow,ProcentMutacji,ProcentKrzyzowania");
                }

                Chromosome best = population.GetBestChromosome();
                double czas = (DateTime.Now - startTime).TotalSeconds;

                string linia = string.Join(",",
                    population.populationID,
                    czas.ToString(CultureInfo.InvariantCulture),
                    generations,
                    stagnationLimit,
                    _lastGeneration,
                    bestFitness,
                    population.basePopulation.Count,
                    best.genes.Count,
                    selectionType,
                    crossoverType,
                    mutationType,
                    PartentRatio.ToString(CultureInfo.InvariantCulture),
                    MutationRatio.ToString(CultureInfo.InvariantCulture),
                    CrossoverRatio.ToString(CultureInfo.InvariantCulture)
                );

                sw.WriteLine(linia);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Wyst¹pi³ b³¹d podczas zapisu do pliku: {ex.Message}", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

