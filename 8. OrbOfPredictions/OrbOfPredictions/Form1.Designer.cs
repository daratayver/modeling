namespace OrbOfPredictions
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.answerLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.probabilityValue = new System.Windows.Forms.NumericUpDown();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.answerButton = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.ballPanel = new System.Windows.Forms.Panel();
			this.ballLabel = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.probabilityValue)).BeginInit();
			this.panel1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.ballPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(808, 460);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.White;
			this.tabPage1.Controls.Add(this.panel2);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.probabilityValue);
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Controls.Add(this.answerButton);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(800, 431);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Tell me ‘yes’ or ‘no’";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.answerLabel);
			this.panel2.Location = new System.Drawing.Point(297, 249);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(202, 81);
			this.panel2.TabIndex = 7;
			// 
			// answerLabel
			// 
			this.answerLabel.BackColor = System.Drawing.Color.MediumAquamarine;
			this.answerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.answerLabel.ForeColor = System.Drawing.Color.White;
			this.answerLabel.Location = new System.Drawing.Point(0, 0);
			this.answerLabel.Name = "answerLabel";
			this.answerLabel.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
			this.answerLabel.Size = new System.Drawing.Size(202, 81);
			this.answerLabel.TabIndex = 4;
			this.answerLabel.Text = "answer";
			this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(292, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 25);
			this.label2.TabIndex = 6;
			this.label2.Text = "Probability:";
			// 
			// probabilityValue
			// 
			this.probabilityValue.DecimalPlaces = 3;
			this.probabilityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.probabilityValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.probabilityValue.Location = new System.Drawing.Point(417, 72);
			this.probabilityValue.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.probabilityValue.Name = "probabilityValue";
			this.probabilityValue.Size = new System.Drawing.Size(82, 31);
			this.probabilityValue.TabIndex = 5;
			this.probabilityValue.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(190, 111);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(413, 53);
			this.panel1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
			this.label1.Size = new System.Drawing.Size(407, 47);
			this.label1.TabIndex = 0;
			this.label1.Text = "Should I go to University today?";
			// 
			// answerButton
			// 
			this.answerButton.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.answerButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
			this.answerButton.FlatAppearance.BorderSize = 2;
			this.answerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.answerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.answerButton.ForeColor = System.Drawing.Color.White;
			this.answerButton.Location = new System.Drawing.Point(337, 170);
			this.answerButton.Name = "answerButton";
			this.answerButton.Size = new System.Drawing.Size(125, 49);
			this.answerButton.TabIndex = 1;
			this.answerButton.Text = "answer";
			this.answerButton.UseVisualStyleBackColor = false;
			this.answerButton.Click += new System.EventHandler(this.AnswerButton_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.Transparent;
			this.tabPage2.Controls.Add(this.ballPanel);
			this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(800, 431);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Magic 8-Ball";
			// 
			// ballPanel
			// 
			this.ballPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ballPanel.BackgroundImage")));
			this.ballPanel.Controls.Add(this.ballLabel);
			this.ballPanel.Location = new System.Drawing.Point(209, 16);
			this.ballPanel.Name = "ballPanel";
			this.ballPanel.Size = new System.Drawing.Size(402, 407);
			this.ballPanel.TabIndex = 0;
			this.ballPanel.Click += new System.EventHandler(this.BallPanel_Click);
			// 
			// ballLabel
			// 
			this.ballLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ballLabel.ForeColor = System.Drawing.Color.White;
			this.ballLabel.Location = new System.Drawing.Point(154, 159);
			this.ballLabel.Name = "ballLabel";
			this.ballLabel.Size = new System.Drawing.Size(97, 77);
			this.ballLabel.TabIndex = 0;
			this.ballLabel.Text = "Click on the ball";
			this.ballLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ballLabel.Click += new System.EventHandler(this.BallLabel_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(808, 460);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Orb Of Predictions";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.probabilityValue)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.ballPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button answerButton;
		private System.Windows.Forms.Label answerLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown probabilityValue;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel ballPanel;
		private System.Windows.Forms.Label ballLabel;
	}
}

