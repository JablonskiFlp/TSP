namespace TSP
{
    partial class TSP
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPopSize = new Label();
            lblNumPop = new Label();
            lblSelection = new Label();
            lblCrossover = new Label();
            lblStagnation = new Label();
            lblGenerations = new Label();
            lblMutationPercent = new Label();
            lblPercent = new Label();
            lblParentRatio = new Label();
            lblMutation = new Label();
            lblFit = new Label();
            txtCrossoverPercent = new TextBox();
            txtPopSize = new TextBox();
            txtNumPop = new TextBox();
            txtGenerations = new TextBox();
            txtStagnation = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtMutationPercent = new TextBox();
            label3 = new Label();
            txtParentRatio = new TextBox();
            cmbSelection = new ComboBox();
            cmbMutation = new ComboBox();
            cmbCrossover = new ComboBox();
            lblSpeed = new Label();
            TrackBar = new TrackBar();
            chkUseSamePopulation = new CheckBox();
            chkSkipVisualisation = new CheckBox();
            lblRepeatCount = new Label();
            txtRepeatCount = new TextBox();
            btnStart = new Button();
            btnSaveFile = new Button();
            btnResume = new Button();
            btnPause = new Button();
            pictureBox = new PictureBox();
            lblIteration = new Label();
            chartBox2 = new PictureBox();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblBestFitness = new Label();
            lblInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)TrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartBox2).BeginInit();
            SuspendLayout();
            // 
            // lblPopSize
            // 
            lblPopSize.AutoSize = true;
            lblPopSize.Location = new Point(20, 20);
            lblPopSize.Name = "lblPopSize";
            lblPopSize.Size = new Size(102, 15);
            lblPopSize.TabIndex = 0;
            lblPopSize.Text = "Rozmiar populacji";
            lblPopSize.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNumPop
            // 
            lblNumPop.AutoSize = true;
            lblNumPop.Location = new Point(20, 54);
            lblNumPop.Name = "lblNumPop";
            lblNumPop.Size = new Size(86, 15);
            lblNumPop.TabIndex = 1;
            lblNumPop.Text = "Liczba pokoleń";
            lblNumPop.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblSelection
            // 
            lblSelection.AutoSize = true;
            lblSelection.Location = new Point(285, 20);
            lblSelection.Name = "lblSelection";
            lblSelection.Size = new Size(52, 15);
            lblSelection.TabIndex = 2;
            lblSelection.Text = "Selekcja:";
            lblSelection.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCrossover
            // 
            lblCrossover.AutoSize = true;
            lblCrossover.Location = new Point(282, 54);
            lblCrossover.Name = "lblCrossover";
            lblCrossover.Size = new Size(75, 15);
            lblCrossover.TabIndex = 3;
            lblCrossover.Text = "Krzyżowanie:";
            lblCrossover.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblStagnation
            // 
            lblStagnation.AutoSize = true;
            lblStagnation.Location = new Point(20, 123);
            lblStagnation.Name = "lblStagnation";
            lblStagnation.Size = new Size(84, 15);
            lblStagnation.TabIndex = 4;
            lblStagnation.Text = "Limit stagnacji";
            lblStagnation.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblGenerations
            // 
            lblGenerations.AutoSize = true;
            lblGenerations.Location = new Point(20, 89);
            lblGenerations.Name = "lblGenerations";
            lblGenerations.Size = new Size(92, 15);
            lblGenerations.TabIndex = 5;
            lblGenerations.Text = "Maks. generacje";
            lblGenerations.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblMutationPercent
            // 
            lblMutationPercent.AutoSize = true;
            lblMutationPercent.Location = new Point(284, 158);
            lblMutationPercent.Name = "lblMutationPercent";
            lblMutationPercent.Size = new Size(53, 15);
            lblMutationPercent.TabIndex = 6;
            lblMutationPercent.Text = "Mutacji: ";
            lblMutationPercent.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.Location = new Point(20, 156);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(193, 15);
            lblPercent.TabIndex = 7;
            lblPercent.Text = "Prawdopodobieństwo krzyżowania:";
            lblPercent.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblParentRatio
            // 
            lblParentRatio.AutoSize = true;
            lblParentRatio.Location = new Point(284, 127);
            lblParentRatio.Name = "lblParentRatio";
            lblParentRatio.Size = new Size(105, 15);
            lblParentRatio.TabIndex = 8;
            lblParentRatio.Text = "Procent Rodziców:";
            lblParentRatio.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblMutation
            // 
            lblMutation.AutoSize = true;
            lblMutation.Location = new Point(282, 89);
            lblMutation.Name = "lblMutation";
            lblMutation.Size = new Size(53, 15);
            lblMutation.TabIndex = 9;
            lblMutation.Text = "Mutacja:";
            lblMutation.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblFit
            // 
            lblFit.AllowDrop = true;
            lblFit.Location = new Point(498, 20);
            lblFit.Name = "lblFit";
            lblFit.Size = new Size(150, 30);
            lblFit.TabIndex = 10;
            lblFit.Text = "Fitness mediany i średniej dla każdego pokolenia";
            lblFit.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtCrossoverPercent
            // 
            txtCrossoverPercent.Location = new Point(217, 148);
            txtCrossoverPercent.Name = "txtCrossoverPercent";
            txtCrossoverPercent.Size = new Size(29, 23);
            txtCrossoverPercent.TabIndex = 11;
            txtCrossoverPercent.Text = "90";
            txtCrossoverPercent.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPopSize
            // 
            txtPopSize.Location = new Point(186, 12);
            txtPopSize.Name = "txtPopSize";
            txtPopSize.Size = new Size(81, 23);
            txtPopSize.TabIndex = 12;
            txtPopSize.Text = "10";
            txtPopSize.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNumPop
            // 
            txtNumPop.Location = new Point(186, 46);
            txtNumPop.Name = "txtNumPop";
            txtNumPop.Size = new Size(81, 23);
            txtNumPop.TabIndex = 13;
            txtNumPop.Text = "10";
            txtNumPop.TextAlign = HorizontalAlignment.Center;
            // 
            // txtGenerations
            // 
            txtGenerations.Location = new Point(186, 81);
            txtGenerations.Name = "txtGenerations";
            txtGenerations.Size = new Size(81, 23);
            txtGenerations.TabIndex = 14;
            txtGenerations.Text = "100";
            txtGenerations.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStagnation
            // 
            txtStagnation.Location = new Point(186, 119);
            txtStagnation.Name = "txtStagnation";
            txtStagnation.Size = new Size(81, 23);
            txtStagnation.TabIndex = 16;
            txtStagnation.Text = "20";
            txtStagnation.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(244, 150);
            label1.Name = "label1";
            label1.Size = new Size(23, 21);
            label1.TabIndex = 17;
            label1.Text = "%";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(371, 153);
            label2.Name = "label2";
            label2.Size = new Size(23, 21);
            label2.TabIndex = 19;
            label2.Text = "%";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtMutationPercent
            // 
            txtMutationPercent.Location = new Point(344, 151);
            txtMutationPercent.Name = "txtMutationPercent";
            txtMutationPercent.Size = new Size(29, 23);
            txtMutationPercent.TabIndex = 18;
            txtMutationPercent.Text = "10";
            txtMutationPercent.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(433, 121);
            label3.Name = "label3";
            label3.Size = new Size(23, 21);
            label3.TabIndex = 21;
            label3.Text = "%";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtParentRatio
            // 
            txtParentRatio.Location = new Point(406, 119);
            txtParentRatio.Name = "txtParentRatio";
            txtParentRatio.Size = new Size(29, 23);
            txtParentRatio.TabIndex = 20;
            txtParentRatio.Text = "50";
            txtParentRatio.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbSelection
            // 
            cmbSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSelection.FormattingEnabled = true;
            cmbSelection.Items.AddRange(new object[] { "ruletkowa", "turniejowa", "rankingowa" });
            cmbSelection.Location = new Point(371, 17);
            cmbSelection.Name = "cmbSelection";
            cmbSelection.Size = new Size(121, 23);
            cmbSelection.TabIndex = 44;
            // 
            // cmbMutation
            // 
            cmbMutation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMutation.FormattingEnabled = true;
            cmbMutation.Items.AddRange(new object[] { "zamiana miejsc", "przetasowanie" });
            cmbMutation.Location = new Point(371, 81);
            cmbMutation.Name = "cmbMutation";
            cmbMutation.Size = new Size(121, 23);
            cmbMutation.TabIndex = 43;
            // 
            // cmbCrossover
            // 
            cmbCrossover.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCrossover.FormattingEnabled = true;
            cmbCrossover.Items.AddRange(new object[] { "porządkowe", "częściowo odwz." });
            cmbCrossover.Location = new Point(371, 51);
            cmbCrossover.Name = "cmbCrossover";
            cmbCrossover.Size = new Size(121, 23);
            cmbCrossover.TabIndex = 42;
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Location = new Point(437, 169);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(55, 15);
            lblSpeed.TabIndex = 26;
            lblSpeed.Text = "Prędkość";
            lblSpeed.TextAlign = ContentAlignment.TopCenter;
            // 
            // TrackBar
            // 
            TrackBar.Location = new Point(498, 158);
            TrackBar.Maximum = 500;
            TrackBar.Minimum = 1;
            TrackBar.Name = "TrackBar";
            TrackBar.Size = new Size(150, 45);
            TrackBar.TabIndex = 27;
            TrackBar.TickFrequency = 100;
            TrackBar.Value = 250;
            TrackBar.Scroll += test;
            // 
            // chkUseSamePopulation
            // 
            chkUseSamePopulation.AutoSize = true;
            chkUseSamePopulation.Location = new Point(20, 208);
            chkUseSamePopulation.Name = "chkUseSamePopulation";
            chkUseSamePopulation.Size = new Size(219, 19);
            chkUseSamePopulation.TabIndex = 31;
            chkUseSamePopulation.Text = "Użyj tej samej populacji początkowej";
            chkUseSamePopulation.UseVisualStyleBackColor = true;
            // 
            // chkSkipVisualisation
            // 
            chkSkipVisualisation.AutoSize = true;
            chkSkipVisualisation.Location = new Point(245, 208);
            chkSkipVisualisation.Name = "chkSkipVisualisation";
            chkSkipVisualisation.Size = new Size(87, 19);
            chkSkipVisualisation.TabIndex = 32;
            chkSkipVisualisation.Text = "Tylko wynik";
            chkSkipVisualisation.UseVisualStyleBackColor = true;
            chkSkipVisualisation.CheckedChanged += chkSkipVisualisation_CheckedChanged;
            // 
            // lblRepeatCount
            // 
            lblRepeatCount.AutoSize = true;
            lblRepeatCount.Location = new Point(344, 209);
            lblRepeatCount.Name = "lblRepeatCount";
            lblRepeatCount.Size = new Size(99, 15);
            lblRepeatCount.TabIndex = 33;
            lblRepeatCount.Text = "Liczba symulacji: ";
            lblRepeatCount.TextAlign = ContentAlignment.TopRight;
            lblRepeatCount.Visible = false;
            // 
            // txtRepeatCount
            // 
            txtRepeatCount.Location = new Point(449, 206);
            txtRepeatCount.Name = "txtRepeatCount";
            txtRepeatCount.Size = new Size(39, 23);
            txtRepeatCount.TabIndex = 34;
            txtRepeatCount.Text = "1";
            txtRepeatCount.TextAlign = HorizontalAlignment.Center;
            txtRepeatCount.Visible = false;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(20, 179);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 35;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Location = new Point(502, 180);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(146, 23);
            btnSaveFile.TabIndex = 36;
            btnSaveFile.Text = "Ustaw ścieżkę zapisu";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // btnResume
            // 
            btnResume.Location = new Point(182, 179);
            btnResume.Name = "btnResume";
            btnResume.Size = new Size(75, 23);
            btnResume.TabIndex = 37;
            btnResume.Text = "Wznów";
            btnResume.UseVisualStyleBackColor = true;
            btnResume.Click += btnResume_Click;
            // 
            // btnPause
            // 
            btnPause.Location = new Point(101, 179);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(75, 23);
            btnPause.TabIndex = 38;
            btnPause.Text = "Pauza";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.White;
            pictureBox.Location = new Point(83, 235);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(500, 500);
            pictureBox.TabIndex = 39;
            pictureBox.TabStop = false;
            // 
            // lblIteration
            // 
            lblIteration.AutoSize = true;
            lblIteration.Location = new Point(20, 724);
            lblIteration.Name = "lblIteration";
            lblIteration.Size = new Size(57, 15);
            lblIteration.TabIndex = 41;
            lblIteration.Text = "Iteracja: 0";
            lblIteration.TextAlign = ContentAlignment.TopCenter;
            // 
            // chartBox2
            // 
            chartBox2.BackColor = Color.White;
            chartBox2.Location = new Point(502, 51);
            chartBox2.Name = "chartBox2";
            chartBox2.Size = new Size(146, 101);
            chartBox2.TabIndex = 45;
            chartBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(263, 180);
            button1.Name = "button1";
            button1.Size = new Size(131, 23);
            button1.TabIndex = 46;
            button1.Text = "Przewiń do końca";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblBestFitness
            // 
            lblBestFitness.AutoSize = true;
            lblBestFitness.Location = new Point(20, 706);
            lblBestFitness.Name = "lblBestFitness";
            lblBestFitness.Size = new Size(30, 15);
            lblBestFitness.TabIndex = 47;
            lblBestFitness.Text = "chuj";
            lblBestFitness.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(523, 212);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(108, 15);
            lblInfo.TabIndex = 48;
            lblInfo.Text = "Algorytm pracuje...";
            lblInfo.Visible = false;
            // 
            // TSP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 748);
            Controls.Add(lblInfo);
            Controls.Add(lblBestFitness);
            Controls.Add(button1);
            Controls.Add(chartBox2);
            Controls.Add(lblIteration);
            Controls.Add(pictureBox);
            Controls.Add(btnPause);
            Controls.Add(btnResume);
            Controls.Add(btnSaveFile);
            Controls.Add(btnStart);
            Controls.Add(txtRepeatCount);
            Controls.Add(lblRepeatCount);
            Controls.Add(chkSkipVisualisation);
            Controls.Add(chkUseSamePopulation);
            Controls.Add(TrackBar);
            Controls.Add(lblSpeed);
            Controls.Add(cmbCrossover);
            Controls.Add(cmbMutation);
            Controls.Add(cmbSelection);
            Controls.Add(label3);
            Controls.Add(txtParentRatio);
            Controls.Add(label2);
            Controls.Add(txtMutationPercent);
            Controls.Add(label1);
            Controls.Add(txtStagnation);
            Controls.Add(txtGenerations);
            Controls.Add(txtNumPop);
            Controls.Add(txtPopSize);
            Controls.Add(txtCrossoverPercent);
            Controls.Add(lblFit);
            Controls.Add(lblMutation);
            Controls.Add(lblParentRatio);
            Controls.Add(lblPercent);
            Controls.Add(lblMutationPercent);
            Controls.Add(lblGenerations);
            Controls.Add(lblStagnation);
            Controls.Add(lblCrossover);
            Controls.Add(lblSelection);
            Controls.Add(lblNumPop);
            Controls.Add(lblPopSize);
            Name = "TSP";
            Text = "Problem Komiwojażera";
            Load += TSP_Load;
            ((System.ComponentModel.ISupportInitialize)TrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPopSize;
        private Label lblNumPop;
        private Label lblSelection;
        private Label lblCrossover;
        private Label lblStagnation;
        private Label lblGenerations;
        private Label lblMutationPercent;
        private Label lblPercent;
        private Label lblParentRatio;
        private Label lblMutation;
        private Label lblFit;
        private TextBox txtCrossoverPercent;
        private TextBox txtPopSize;
        private TextBox txtNumPop;
        private TextBox txtGenerations;
        private TextBox txtStagnation;
        private Label label1;
        private Label label2;
        private TextBox txtMutationPercent;
        private Label label3;
        private TextBox txtParentRatio;
        private ComboBox cmbSelection;
        private ComboBox cmbMutation;
        private ComboBox cmbCrossover;
        private PictureBox chartBox;
        private PictureBox chartBox2;
        private Label lblSpeed;
        private TrackBar TrackBar;
        private CheckBox chkUseSamePopulation;
        private CheckBox chkSkipVisualisation;
        private Label lblRepeatCount;
        private TextBox txtRepeatCount;
        private Button btnStart;
        private Button btnSaveFile;
        private Button btnResume;
        private Button btnPause;
        private PictureBox pictureBox;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblIteration;
        private Label lblBestFitness;
        private Label lblInfo;
    }
}
