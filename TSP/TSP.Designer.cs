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
            lblParentRatio = new Label();
            lblMutation = new Label();
            lblFit = new Label();
            txtCrossoverPercent = new TextBox();
            txtCityCount = new TextBox();
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)TrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartBox2).BeginInit();
            SuspendLayout();
            // 
            // lblPopSize
            // 
            lblPopSize.AutoSize = true;
            lblPopSize.Font = new Font("Segoe UI", 14F);
            lblPopSize.Location = new Point(9, 101);
            lblPopSize.Name = "lblPopSize";
            lblPopSize.Size = new Size(100, 25);
            lblPopSize.TabIndex = 0;
            lblPopSize.Text = "Ilość miast";
            lblPopSize.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNumPop
            // 
            lblNumPop.AutoSize = true;
            lblNumPop.Font = new Font("Segoe UI", 12F);
            lblNumPop.Location = new Point(9, 148);
            lblNumPop.Name = "lblNumPop";
            lblNumPop.Size = new Size(135, 21);
            lblNumPop.TabIndex = 1;
            lblNumPop.Text = "Rozmiar populacji";
            lblNumPop.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblSelection
            // 
            lblSelection.AutoSize = true;
            lblSelection.Font = new Font("Segoe UI", 12F);
            lblSelection.Location = new Point(9, 250);
            lblSelection.Name = "lblSelection";
            lblSelection.Size = new Size(69, 21);
            lblSelection.TabIndex = 2;
            lblSelection.Text = "Selekcja:";
            lblSelection.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCrossover
            // 
            lblCrossover.AutoSize = true;
            lblCrossover.Font = new Font("Segoe UI", 12F);
            lblCrossover.Location = new Point(9, 280);
            lblCrossover.Name = "lblCrossover";
            lblCrossover.Size = new Size(100, 21);
            lblCrossover.TabIndex = 3;
            lblCrossover.Text = "Krzyżowanie:";
            lblCrossover.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblStagnation
            // 
            lblStagnation.AutoSize = true;
            lblStagnation.Font = new Font("Segoe UI", 12F);
            lblStagnation.Location = new Point(9, 196);
            lblStagnation.Name = "lblStagnation";
            lblStagnation.Size = new Size(110, 21);
            lblStagnation.TabIndex = 4;
            lblStagnation.Text = "Limit stagnacji";
            lblStagnation.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblGenerations
            // 
            lblGenerations.AutoSize = true;
            lblGenerations.Font = new Font("Segoe UI", 12F);
            lblGenerations.Location = new Point(9, 172);
            lblGenerations.Name = "lblGenerations";
            lblGenerations.Size = new Size(113, 21);
            lblGenerations.TabIndex = 5;
            lblGenerations.Text = "Liczba pokoleń";
            lblGenerations.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblMutationPercent
            // 
            lblMutationPercent.AutoSize = true;
            lblMutationPercent.Font = new Font("Segoe UI", 12F);
            lblMutationPercent.Location = new Point(12, 421);
            lblMutationPercent.Name = "lblMutationPercent";
            lblMutationPercent.Size = new Size(68, 21);
            lblMutationPercent.TabIndex = 6;
            lblMutationPercent.Text = "Mutacji: ";
            lblMutationPercent.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblParentRatio
            // 
            lblParentRatio.AutoSize = true;
            lblParentRatio.Font = new Font("Segoe UI", 12F);
            lblParentRatio.Location = new Point(12, 455);
            lblParentRatio.Name = "lblParentRatio";
            lblParentRatio.Size = new Size(137, 21);
            lblParentRatio.TabIndex = 8;
            lblParentRatio.Text = "Procent Rodziców:";
            lblParentRatio.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblMutation
            // 
            lblMutation.AutoSize = true;
            lblMutation.Font = new Font("Segoe UI", 12F);
            lblMutation.Location = new Point(9, 309);
            lblMutation.Name = "lblMutation";
            lblMutation.Size = new Size(68, 21);
            lblMutation.TabIndex = 9;
            lblMutation.Text = "Mutacja:";
            lblMutation.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblFit
            // 
            lblFit.AllowDrop = true;
            lblFit.Font = new Font("Segoe UI", 12F);
            lblFit.Location = new Point(769, 99);
            lblFit.Name = "lblFit";
            lblFit.Size = new Size(160, 66);
            lblFit.TabIndex = 10;
            lblFit.Text = "Ewolucja najlepszego i średniego fitnessu w kolejnych pokoleniach";
            lblFit.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtCrossoverPercent
            // 
            txtCrossoverPercent.Location = new Point(182, 394);
            txtCrossoverPercent.Margin = new Padding(3, 2, 3, 2);
            txtCrossoverPercent.Name = "txtCrossoverPercent";
            txtCrossoverPercent.Size = new Size(23, 23);
            txtCrossoverPercent.TabIndex = 11;
            txtCrossoverPercent.Text = "90";
            txtCrossoverPercent.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCityCount
            // 
            txtCityCount.Location = new Point(160, 105);
            txtCityCount.Margin = new Padding(3, 2, 3, 2);
            txtCityCount.Name = "txtCityCount";
            txtCityCount.Size = new Size(72, 23);
            txtCityCount.TabIndex = 12;
            txtCityCount.Text = "10";
            txtCityCount.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNumPop
            // 
            txtNumPop.Location = new Point(171, 148);
            txtNumPop.Margin = new Padding(3, 2, 3, 2);
            txtNumPop.Name = "txtNumPop";
            txtNumPop.Size = new Size(59, 23);
            txtNumPop.TabIndex = 13;
            txtNumPop.Text = "10";
            txtNumPop.TextAlign = HorizontalAlignment.Center;
            // 
            // txtGenerations
            // 
            txtGenerations.Location = new Point(171, 173);
            txtGenerations.Margin = new Padding(3, 2, 3, 2);
            txtGenerations.Name = "txtGenerations";
            txtGenerations.Size = new Size(59, 23);
            txtGenerations.TabIndex = 14;
            txtGenerations.Text = "100";
            txtGenerations.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStagnation
            // 
            txtStagnation.Location = new Point(171, 198);
            txtStagnation.Margin = new Padding(3, 2, 3, 2);
            txtStagnation.Name = "txtStagnation";
            txtStagnation.Size = new Size(59, 23);
            txtStagnation.TabIndex = 16;
            txtStagnation.Text = "20";
            txtStagnation.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(209, 396);
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
            label2.Location = new Point(209, 421);
            label2.Name = "label2";
            label2.Size = new Size(23, 21);
            label2.TabIndex = 19;
            label2.Text = "%";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtMutationPercent
            // 
            txtMutationPercent.Location = new Point(182, 419);
            txtMutationPercent.Margin = new Padding(3, 2, 3, 2);
            txtMutationPercent.Name = "txtMutationPercent";
            txtMutationPercent.Size = new Size(23, 23);
            txtMutationPercent.TabIndex = 18;
            txtMutationPercent.Text = "10";
            txtMutationPercent.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(209, 455);
            label3.Name = "label3";
            label3.Size = new Size(23, 21);
            label3.TabIndex = 21;
            label3.Text = "%";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtParentRatio
            // 
            txtParentRatio.Location = new Point(182, 454);
            txtParentRatio.Margin = new Padding(3, 2, 3, 2);
            txtParentRatio.Name = "txtParentRatio";
            txtParentRatio.Size = new Size(23, 23);
            txtParentRatio.TabIndex = 20;
            txtParentRatio.Text = "50";
            txtParentRatio.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbSelection
            // 
            cmbSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSelection.FormattingEnabled = true;
            cmbSelection.Items.AddRange(new object[] { "ruletkowa", "turniejowa", "rankingowa" });
            cmbSelection.Location = new Point(144, 252);
            cmbSelection.Margin = new Padding(3, 2, 3, 2);
            cmbSelection.Name = "cmbSelection";
            cmbSelection.Size = new Size(88, 23);
            cmbSelection.TabIndex = 44;
            // 
            // cmbMutation
            // 
            cmbMutation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMutation.FormattingEnabled = true;
            cmbMutation.Items.AddRange(new object[] { "zamiana miejsc", "przetasowanie" });
            cmbMutation.Location = new Point(144, 314);
            cmbMutation.Margin = new Padding(3, 2, 3, 2);
            cmbMutation.Name = "cmbMutation";
            cmbMutation.Size = new Size(88, 23);
            cmbMutation.TabIndex = 43;
            // 
            // cmbCrossover
            // 
            cmbCrossover.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCrossover.FormattingEnabled = true;
            cmbCrossover.Items.AddRange(new object[] { "porządkowe", "częściowo odwz." });
            cmbCrossover.Location = new Point(144, 281);
            cmbCrossover.Margin = new Padding(3, 2, 3, 2);
            cmbCrossover.Name = "cmbCrossover";
            cmbCrossover.Size = new Size(88, 23);
            cmbCrossover.TabIndex = 42;
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Font = new Font("Segoe UI", 12F);
            lblSpeed.Location = new Point(761, 297);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(73, 21);
            lblSpeed.TabIndex = 26;
            lblSpeed.Text = "Prędkość";
            lblSpeed.TextAlign = ContentAlignment.TopCenter;
            // 
            // TrackBar
            // 
            TrackBar.Location = new Point(761, 325);
            TrackBar.Margin = new Padding(3, 2, 3, 2);
            TrackBar.Maximum = 500;
            TrackBar.Minimum = 1;
            TrackBar.Name = "TrackBar";
            TrackBar.Size = new Size(147, 45);
            TrackBar.TabIndex = 27;
            TrackBar.TickFrequency = 100;
            TrackBar.Value = 250;
            TrackBar.Scroll += test;
            // 
            // chkUseSamePopulation
            // 
            chkUseSamePopulation.AutoSize = true;
            chkUseSamePopulation.Font = new Font("Segoe UI", 10F);
            chkUseSamePopulation.Location = new Point(227, 16);
            chkUseSamePopulation.Margin = new Padding(3, 2, 3, 2);
            chkUseSamePopulation.Name = "chkUseSamePopulation";
            chkUseSamePopulation.Size = new Size(249, 23);
            chkUseSamePopulation.TabIndex = 31;
            chkUseSamePopulation.Text = "Użyj tej samej populacji początkowej";
            chkUseSamePopulation.UseVisualStyleBackColor = true;
            // 
            // chkSkipVisualisation
            // 
            chkSkipVisualisation.AutoSize = true;
            chkSkipVisualisation.Font = new Font("Segoe UI", 10F);
            chkSkipVisualisation.Location = new Point(507, 16);
            chkSkipVisualisation.Margin = new Padding(3, 2, 3, 2);
            chkSkipVisualisation.Name = "chkSkipVisualisation";
            chkSkipVisualisation.Size = new Size(98, 23);
            chkSkipVisualisation.TabIndex = 32;
            chkSkipVisualisation.Text = "Tylko wynik";
            chkSkipVisualisation.UseVisualStyleBackColor = true;
            chkSkipVisualisation.CheckedChanged += chkSkipVisualisation_CheckedChanged;
            // 
            // lblRepeatCount
            // 
            lblRepeatCount.AutoSize = true;
            lblRepeatCount.Font = new Font("Segoe UI", 10F);
            lblRepeatCount.Location = new Point(615, 16);
            lblRepeatCount.Name = "lblRepeatCount";
            lblRepeatCount.Size = new Size(112, 19);
            lblRepeatCount.TabIndex = 33;
            lblRepeatCount.Text = "Liczba symulacji: ";
            lblRepeatCount.TextAlign = ContentAlignment.TopRight;
            lblRepeatCount.Visible = false;
            // 
            // txtRepeatCount
            // 
            txtRepeatCount.Font = new Font("Segoe UI", 10F);
            txtRepeatCount.Location = new Point(724, 13);
            txtRepeatCount.Margin = new Padding(3, 2, 3, 2);
            txtRepeatCount.Name = "txtRepeatCount";
            txtRepeatCount.Size = new Size(31, 25);
            txtRepeatCount.TabIndex = 34;
            txtRepeatCount.Text = "1";
            txtRepeatCount.TextAlign = HorizontalAlignment.Center;
            txtRepeatCount.Visible = false;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 14F);
            btnStart.Location = new Point(31, 509);
            btnStart.Margin = new Padding(3, 2, 3, 2);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(172, 34);
            btnStart.TabIndex = 35;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Font = new Font("Segoe UI", 12F);
            btnSaveFile.Location = new Point(761, 54);
            btnSaveFile.Margin = new Padding(3, 2, 3, 2);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(181, 37);
            btnSaveFile.TabIndex = 36;
            btnSaveFile.Text = "Ustaw ścieżkę zapisu";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // btnResume
            // 
            btnResume.Font = new Font("Segoe UI", 10F);
            btnResume.Location = new Point(370, 547);
            btnResume.Margin = new Padding(3, 2, 3, 2);
            btnResume.Name = "btnResume";
            btnResume.Size = new Size(116, 32);
            btnResume.TabIndex = 37;
            btnResume.Text = "Wznów";
            btnResume.UseVisualStyleBackColor = true;
            btnResume.Click += btnResume_Click;
            // 
            // btnPause
            // 
            btnPause.Font = new Font("Segoe UI", 10F);
            btnPause.Location = new Point(238, 547);
            btnPause.Margin = new Padding(3, 2, 3, 2);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(119, 32);
            btnPause.TabIndex = 38;
            btnPause.Text = "Pauza";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.White;
            pictureBox.Location = new Point(238, 43);
            pictureBox.Margin = new Padding(3, 2, 3, 2);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(500, 500);
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.TabIndex = 39;
            pictureBox.TabStop = false;
            // 
            // lblIteration
            // 
            lblIteration.AutoSize = true;
            lblIteration.Font = new Font("Segoe UI", 12F);
            lblIteration.Location = new Point(769, 442);
            lblIteration.Name = "lblIteration";
            lblIteration.Size = new Size(76, 21);
            lblIteration.TabIndex = 41;
            lblIteration.Text = "Iteracja: 0";
            lblIteration.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chartBox2
            // 
            chartBox2.BackColor = Color.White;
            chartBox2.Location = new Point(769, 172);
            chartBox2.Margin = new Padding(3, 2, 3, 2);
            chartBox2.Name = "chartBox2";
            chartBox2.Size = new Size(168, 87);
            chartBox2.TabIndex = 45;
            chartBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(492, 547);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(133, 32);
            button1.TabIndex = 46;
            button1.Text = "Przewiń do końca";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblBestFitness
            // 
            lblBestFitness.Font = new Font("Segoe UI", 12F);
            lblBestFitness.Location = new Point(769, 402);
            lblBestFitness.Name = "lblBestFitness";
            lblBestFitness.Size = new Size(196, 26);
            lblBestFitness.TabIndex = 47;
            lblBestFitness.Text = "Najlepszy fitness: 0";
            lblBestFitness.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 12F);
            lblInfo.Location = new Point(769, 503);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(139, 21);
            lblInfo.TabIndex = 48;
            lblInfo.Text = "Algorytm pracuje...";
            lblInfo.Visible = false;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(10, 7);
            label4.Name = "label4";
            label4.Size = new Size(211, 84);
            label4.TabIndex = 49;
            label4.Text = "Problem Komiwojażera";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 362);
            label5.Name = "label5";
            label5.Size = new Size(186, 22);
            label5.TabIndex = 50;
            label5.Text = "Prawdopodobieństwo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 392);
            label6.Name = "label6";
            label6.Size = new Size(100, 21);
            label6.TabIndex = 51;
            label6.Text = "Krzyżowania:";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 10F);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(639, 547);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(99, 32);
            button2.TabIndex = 52;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // TSP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 582);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
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
            Controls.Add(txtCityCount);
            Controls.Add(txtCrossoverPercent);
            Controls.Add(lblFit);
            Controls.Add(lblMutation);
            Controls.Add(lblParentRatio);
            Controls.Add(lblMutationPercent);
            Controls.Add(lblGenerations);
            Controls.Add(lblStagnation);
            Controls.Add(lblCrossover);
            Controls.Add(lblSelection);
            Controls.Add(lblNumPop);
            Controls.Add(lblPopSize);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label lblParentRatio;
        private Label lblMutation;
        private Label lblFit;
        private TextBox txtCrossoverPercent;
        private TextBox txtCityCount;
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
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
    }
}
