namespace StatisticsOfEventGenerating
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.panel1 = new System.Windows.Forms.Panel();
			this.startButton = new System.Windows.Forms.Button();
			this.prob5Value = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.numberValue = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.prob4Value = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.prob3Value = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.prob2Value = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.prob1Value = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numberValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.prob4Value)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.prob3Value)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.prob2Value)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.prob1Value)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.startButton);
			this.panel1.Controls.Add(this.prob5Value);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.numberValue);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.prob4Value);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.prob3Value);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.prob2Value);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.prob1Value);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(307, 450);
			this.panel1.TabIndex = 0;
			// 
			// startButton
			// 
			this.startButton.BackColor = System.Drawing.Color.LightSkyBlue;
			this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.startButton.Location = new System.Drawing.Point(191, 229);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(94, 30);
			this.startButton.TabIndex = 3;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = false;
			this.startButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// prob5Value
			// 
			this.prob5Value.BackColor = System.Drawing.Color.White;
			this.prob5Value.Enabled = false;
			this.prob5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.prob5Value.Location = new System.Drawing.Point(73, 150);
			this.prob5Value.Name = "prob5Value";
			this.prob5Value.Size = new System.Drawing.Size(120, 26);
			this.prob5Value.TabIndex = 2;
			this.prob5Value.Text = "1,000";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(12, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 20);
			this.label5.TabIndex = 0;
			this.label5.Text = "Prob 5";
			// 
			// numberValue
			// 
			this.numberValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numberValue.Location = new System.Drawing.Point(191, 197);
			this.numberValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.numberValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numberValue.Name = "numberValue";
			this.numberValue.Size = new System.Drawing.Size(94, 26);
			this.numberValue.TabIndex = 1;
			this.numberValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(12, 199);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(173, 20);
			this.label6.TabIndex = 0;
			this.label6.Text = "Number of experiments";
			// 
			// prob4Value
			// 
			this.prob4Value.DecimalPlaces = 3;
			this.prob4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.prob4Value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.prob4Value.Location = new System.Drawing.Point(73, 118);
			this.prob4Value.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.prob4Value.Name = "prob4Value";
			this.prob4Value.Size = new System.Drawing.Size(120, 26);
			this.prob4Value.TabIndex = 1;
			this.prob4Value.ValueChanged += new System.EventHandler(this.ProbValue_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 20);
			this.label4.TabIndex = 0;
			this.label4.Text = "Prob 4";
			// 
			// prob3Value
			// 
			this.prob3Value.DecimalPlaces = 3;
			this.prob3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.prob3Value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.prob3Value.Location = new System.Drawing.Point(73, 86);
			this.prob3Value.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.prob3Value.Name = "prob3Value";
			this.prob3Value.Size = new System.Drawing.Size(120, 26);
			this.prob3Value.TabIndex = 1;
			this.prob3Value.ValueChanged += new System.EventHandler(this.ProbValue_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Prob 3";
			// 
			// prob2Value
			// 
			this.prob2Value.DecimalPlaces = 3;
			this.prob2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.prob2Value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.prob2Value.Location = new System.Drawing.Point(73, 54);
			this.prob2Value.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.prob2Value.Name = "prob2Value";
			this.prob2Value.Size = new System.Drawing.Size(120, 26);
			this.prob2Value.TabIndex = 1;
			this.prob2Value.ValueChanged += new System.EventHandler(this.ProbValue_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Prob 2";
			// 
			// prob1Value
			// 
			this.prob1Value.DecimalPlaces = 3;
			this.prob1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.prob1Value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.prob1Value.Location = new System.Drawing.Point(73, 22);
			this.prob1Value.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.prob1Value.Name = "prob1Value";
			this.prob1Value.Size = new System.Drawing.Size(120, 26);
			this.prob1Value.TabIndex = 1;
			this.prob1Value.ValueChanged += new System.EventHandler(this.ProbValue_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Prob 1";
			// 
			// chart1
			// 
			chartArea2.AxisX.Minimum = 0D;
			chartArea2.AxisY.Minimum = 0D;
			chartArea2.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea2);
			this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chart1.Location = new System.Drawing.Point(307, 0);
			this.chart1.Name = "chart1";
			series2.ChartArea = "ChartArea1";
			series2.Name = "Series1";
			series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
			this.chart1.Series.Add(series2);
			this.chart1.Size = new System.Drawing.Size(608, 450);
			this.chart1.TabIndex = 1;
			this.chart1.Text = "chart1";
			title2.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			title2.Name = "Freq";
			title2.Text = "freq.";
			this.chart1.Titles.Add(title2);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(915, 450);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Statistics Of Event Generating";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numberValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.prob4Value)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.prob3Value)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.prob2Value)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.prob1Value)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown prob4Value;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown prob3Value;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown prob2Value;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown prob1Value;
		private System.Windows.Forms.TextBox prob5Value;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.NumericUpDown numberValue;
		private System.Windows.Forms.Label label6;
	}
}

