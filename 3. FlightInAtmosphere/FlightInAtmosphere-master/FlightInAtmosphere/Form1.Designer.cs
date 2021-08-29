namespace FlightInAtmosphere
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.panel1 = new System.Windows.Forms.Panel();
			this.weightNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.sizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.timeLabel = new System.Windows.Forms.Label();
			this.speedNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.angleNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.launchButton = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sizeNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.speedNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.angleNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.weightNumericUpDown);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.sizeNumericUpDown);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.timeLabel);
			this.panel1.Controls.Add(this.speedNumericUpDown);
			this.panel1.Controls.Add(this.angleNumericUpDown);
			this.panel1.Controls.Add(this.heightNumericUpDown);
			this.panel1.Controls.Add(this.launchButton);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(737, 113);
			this.panel1.TabIndex = 0;
			// 
			// weightNumericUpDown
			// 
			this.weightNumericUpDown.Location = new System.Drawing.Point(262, 41);
			this.weightNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.weightNumericUpDown.Name = "weightNumericUpDown";
			this.weightNumericUpDown.Size = new System.Drawing.Size(120, 26);
			this.weightNumericUpDown.TabIndex = 14;
			this.weightNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(200, 43);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 20);
			this.label5.TabIndex = 13;
			this.label5.Text = "Weight";
			// 
			// sizeNumericUpDown
			// 
			this.sizeNumericUpDown.DecimalPlaces = 2;
			this.sizeNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.sizeNumericUpDown.Location = new System.Drawing.Point(262, 9);
			this.sizeNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.sizeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.sizeNumericUpDown.Name = "sizeNumericUpDown";
			this.sizeNumericUpDown.Size = new System.Drawing.Size(120, 26);
			this.sizeNumericUpDown.TabIndex = 12;
			this.sizeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(216, 11);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 20);
			this.label4.TabIndex = 11;
			this.label4.Text = "Size";
			// 
			// timeLabel
			// 
			this.timeLabel.AutoSize = true;
			this.timeLabel.Location = new System.Drawing.Point(449, 22);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(94, 20);
			this.timeLabel.TabIndex = 10;
			this.timeLabel.Text = "Time: 0.00 c";
			// 
			// speedNumericUpDown
			// 
			this.speedNumericUpDown.Location = new System.Drawing.Point(74, 73);
			this.speedNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.speedNumericUpDown.Name = "speedNumericUpDown";
			this.speedNumericUpDown.Size = new System.Drawing.Size(120, 26);
			this.speedNumericUpDown.TabIndex = 9;
			this.speedNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// angleNumericUpDown
			// 
			this.angleNumericUpDown.Location = new System.Drawing.Point(74, 41);
			this.angleNumericUpDown.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
			this.angleNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.angleNumericUpDown.Name = "angleNumericUpDown";
			this.angleNumericUpDown.Size = new System.Drawing.Size(120, 26);
			this.angleNumericUpDown.TabIndex = 8;
			this.angleNumericUpDown.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
			// 
			// heightNumericUpDown
			// 
			this.heightNumericUpDown.Location = new System.Drawing.Point(74, 9);
			this.heightNumericUpDown.Name = "heightNumericUpDown";
			this.heightNumericUpDown.Size = new System.Drawing.Size(120, 26);
			this.heightNumericUpDown.TabIndex = 7;
			// 
			// launchButton
			// 
			this.launchButton.ImageIndex = 0;
			this.launchButton.ImageList = this.imageList1;
			this.launchButton.Location = new System.Drawing.Point(403, 12);
			this.launchButton.Name = "launchButton";
			this.launchButton.Size = new System.Drawing.Size(40, 40);
			this.launchButton.TabIndex = 6;
			this.launchButton.UseVisualStyleBackColor = true;
			this.launchButton.Click += new System.EventHandler(this.LaunchButton_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "play-button (1).png");
			this.imageList1.Images.SetKeyName(1, "pause (1).png");
			this.imageList1.Images.SetKeyName(2, "stop.png");
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Speed";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Angle";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Height";
			// 
			// chart1
			// 
			chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
			chartArea3.AxisX.Minimum = 0D;
			chartArea3.AxisX.Title = "s, m";
			chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
			chartArea3.AxisY.Minimum = 0D;
			chartArea3.AxisY.Title = "h, m";
			chartArea3.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea3);
			this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chart1.Location = new System.Drawing.Point(0, 113);
			this.chart1.Name = "chart1";
			series3.BorderWidth = 5;
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			series3.Name = "Series1";
			this.chart1.Series.Add(series3);
			this.chart1.Size = new System.Drawing.Size(737, 483);
			this.chart1.TabIndex = 1;
			this.chart1.Text = "chart1";
			// 
			// timer1
			// 
			this.timer1.Interval = 1;
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(737, 596);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Flight In Atmosphere";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sizeNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.speedNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.angleNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button launchButton;
		private System.Windows.Forms.NumericUpDown heightNumericUpDown;
		private System.Windows.Forms.NumericUpDown speedNumericUpDown;
		private System.Windows.Forms.NumericUpDown angleNumericUpDown;
		private System.Windows.Forms.Label timeLabel;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.NumericUpDown sizeNumericUpDown;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown weightNumericUpDown;
		private System.Windows.Forms.Label label5;
	}
}

