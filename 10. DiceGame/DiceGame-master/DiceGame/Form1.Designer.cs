namespace DiceGame
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
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.rollButton = new System.Windows.Forms.Button();
			this.table = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.player = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.sum = new System.Windows.Forms.Label();
			this.bonus = new System.Windows.Forms.Label();
			this.total = new System.Windows.Forms.Label();
			this.twos = new System.Windows.Forms.Label();
			this.ones = new System.Windows.Forms.Label();
			this.threes = new System.Windows.Forms.Label();
			this.fours = new System.Windows.Forms.Label();
			this.fives = new System.Windows.Forms.Label();
			this.sixes = new System.Windows.Forms.Label();
			this.threeKind = new System.Windows.Forms.Label();
			this.fourKind = new System.Windows.Forms.Label();
			this.fullHouse = new System.Windows.Forms.Label();
			this.smStraight = new System.Windows.Forms.Label();
			this.lgStraight = new System.Windows.Forms.Label();
			this.fiveKind = new System.Windows.Forms.Label();
			this.chance = new System.Windows.Forms.Label();
			this.gamePanel = new System.Windows.Forms.Panel();
			this.exitButton = new System.Windows.Forms.Button();
			this.dicePanel = new System.Windows.Forms.Panel();
			this.dice1 = new System.Windows.Forms.Panel();
			this.dice2 = new System.Windows.Forms.Panel();
			this.dice3 = new System.Windows.Forms.Panel();
			this.dice4 = new System.Windows.Forms.Panel();
			this.dice5 = new System.Windows.Forms.Panel();
			this.startPanel = new System.Windows.Forms.Panel();
			this.playButton = new System.Windows.Forms.Button();
			this.CheatingCheckBox = new System.Windows.Forms.CheckBox();
			this.endPanel = new System.Windows.Forms.Panel();
			this.finishButton = new System.Windows.Forms.Button();
			this.result = new System.Windows.Forms.Label();
			this.label = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.move = new System.Windows.Forms.Label();
			this.table.SuspendLayout();
			this.gamePanel.SuspendLayout();
			this.dicePanel.SuspendLayout();
			this.startPanel.SuspendLayout();
			this.endPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "1_dot.png");
			this.imageList1.Images.SetKeyName(1, "2_dots.png");
			this.imageList1.Images.SetKeyName(2, "3_dots.png");
			this.imageList1.Images.SetKeyName(3, "4_dots.png");
			this.imageList1.Images.SetKeyName(4, "5_dots.png");
			this.imageList1.Images.SetKeyName(5, "6_dots.png");
			// 
			// rollButton
			// 
			this.rollButton.BackColor = System.Drawing.Color.Gold;
			this.rollButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rollButton.Location = new System.Drawing.Point(10, 453);
			this.rollButton.Name = "rollButton";
			this.rollButton.Size = new System.Drawing.Size(80, 53);
			this.rollButton.TabIndex = 2;
			this.rollButton.Text = "Roll";
			this.rollButton.UseVisualStyleBackColor = false;
			this.rollButton.Click += new System.EventHandler(this.RollButton_Click);
			// 
			// table
			// 
			this.table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.table.ColumnCount = 2;
			this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.table.Controls.Add(this.label1, 0, 0);
			this.table.Controls.Add(this.player, 1, 0);
			this.table.Controls.Add(this.label4, 0, 1);
			this.table.Controls.Add(this.label5, 0, 2);
			this.table.Controls.Add(this.label6, 0, 3);
			this.table.Controls.Add(this.label7, 0, 4);
			this.table.Controls.Add(this.label8, 0, 5);
			this.table.Controls.Add(this.label9, 0, 6);
			this.table.Controls.Add(this.label12, 0, 11);
			this.table.Controls.Add(this.label11, 0, 9);
			this.table.Controls.Add(this.label10, 0, 8);
			this.table.Controls.Add(this.label13, 0, 12);
			this.table.Controls.Add(this.label14, 0, 13);
			this.table.Controls.Add(this.label15, 0, 14);
			this.table.Controls.Add(this.label16, 0, 15);
			this.table.Controls.Add(this.label17, 0, 16);
			this.table.Controls.Add(this.label18, 0, 17);
			this.table.Controls.Add(this.label19, 0, 19);
			this.table.Controls.Add(this.sum, 1, 8);
			this.table.Controls.Add(this.bonus, 1, 9);
			this.table.Controls.Add(this.total, 1, 19);
			this.table.Controls.Add(this.twos, 1, 2);
			this.table.Controls.Add(this.ones, 1, 1);
			this.table.Controls.Add(this.threes, 1, 3);
			this.table.Controls.Add(this.fours, 1, 4);
			this.table.Controls.Add(this.fives, 1, 5);
			this.table.Controls.Add(this.sixes, 1, 6);
			this.table.Controls.Add(this.threeKind, 1, 11);
			this.table.Controls.Add(this.fourKind, 1, 12);
			this.table.Controls.Add(this.fullHouse, 1, 13);
			this.table.Controls.Add(this.smStraight, 1, 14);
			this.table.Controls.Add(this.lgStraight, 1, 15);
			this.table.Controls.Add(this.fiveKind, 1, 16);
			this.table.Controls.Add(this.chance, 1, 17);
			this.table.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.table.Location = new System.Drawing.Point(113, 12);
			this.table.Name = "table";
			this.table.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.table.RowCount = 20;
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.table.Size = new System.Drawing.Size(397, 435);
			this.table.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(4, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(256, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Combinations";
			// 
			// player
			// 
			this.player.Location = new System.Drawing.Point(267, 1);
			this.player.Name = "player";
			this.player.Size = new System.Drawing.Size(126, 19);
			this.player.TabIndex = 1;
			this.player.Text = "Player";
			this.player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(4, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(256, 19);
			this.label4.TabIndex = 0;
			this.label4.Text = "Ones";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(4, 43);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(256, 19);
			this.label5.TabIndex = 0;
			this.label5.Text = "Twos";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(4, 64);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(256, 19);
			this.label6.TabIndex = 0;
			this.label6.Text = "Threes";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(4, 85);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(256, 19);
			this.label7.TabIndex = 0;
			this.label7.Text = "Fours";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(4, 106);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(256, 19);
			this.label8.TabIndex = 0;
			this.label8.Text = "Fives";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(4, 127);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(256, 19);
			this.label9.TabIndex = 0;
			this.label9.Text = "Sixes";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(4, 232);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(256, 19);
			this.label12.TabIndex = 0;
			this.label12.Text = "3 of a kind";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Gold;
			this.label11.Location = new System.Drawing.Point(4, 190);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(256, 19);
			this.label11.TabIndex = 0;
			this.label11.Text = "Bonus";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Gold;
			this.label10.Location = new System.Drawing.Point(4, 169);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(256, 19);
			this.label10.TabIndex = 0;
			this.label10.Text = "Sum";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(4, 253);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(256, 19);
			this.label13.TabIndex = 0;
			this.label13.Text = "4 of a kind";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(4, 274);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(256, 19);
			this.label14.TabIndex = 0;
			this.label14.Text = "Full House";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(4, 295);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(256, 19);
			this.label15.TabIndex = 0;
			this.label15.Text = "Sm. Straight";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(4, 316);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(256, 19);
			this.label16.TabIndex = 0;
			this.label16.Text = "Lg. Straight";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(4, 337);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(256, 19);
			this.label17.TabIndex = 0;
			this.label17.Text = "5 of a kind";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(4, 358);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(256, 19);
			this.label18.TabIndex = 0;
			this.label18.Text = "Chance";
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Gold;
			this.label19.Location = new System.Drawing.Point(4, 414);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(256, 19);
			this.label19.TabIndex = 0;
			this.label19.Text = "Total";
			// 
			// sum
			// 
			this.sum.BackColor = System.Drawing.Color.Gold;
			this.sum.Location = new System.Drawing.Point(267, 169);
			this.sum.Name = "sum";
			this.sum.Size = new System.Drawing.Size(126, 20);
			this.sum.TabIndex = 3;
			this.sum.Text = "0";
			this.sum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// bonus
			// 
			this.bonus.BackColor = System.Drawing.Color.Gold;
			this.bonus.Location = new System.Drawing.Point(267, 190);
			this.bonus.Name = "bonus";
			this.bonus.Size = new System.Drawing.Size(126, 20);
			this.bonus.TabIndex = 3;
			this.bonus.Text = "0";
			this.bonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// total
			// 
			this.total.BackColor = System.Drawing.Color.Gold;
			this.total.Location = new System.Drawing.Point(267, 414);
			this.total.Name = "total";
			this.total.Size = new System.Drawing.Size(126, 20);
			this.total.TabIndex = 3;
			this.total.Text = "0";
			this.total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// twos
			// 
			this.twos.Location = new System.Drawing.Point(267, 43);
			this.twos.Name = "twos";
			this.twos.Size = new System.Drawing.Size(126, 20);
			this.twos.TabIndex = 3;
			this.twos.Text = "0";
			this.twos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.twos.Click += new System.EventHandler(this.Combo_Click);
			// 
			// ones
			// 
			this.ones.Location = new System.Drawing.Point(267, 22);
			this.ones.Name = "ones";
			this.ones.Size = new System.Drawing.Size(126, 20);
			this.ones.TabIndex = 3;
			this.ones.Text = "0";
			this.ones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ones.Click += new System.EventHandler(this.Combo_Click);
			// 
			// threes
			// 
			this.threes.Location = new System.Drawing.Point(267, 64);
			this.threes.Name = "threes";
			this.threes.Size = new System.Drawing.Size(126, 20);
			this.threes.TabIndex = 3;
			this.threes.Text = "0";
			this.threes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.threes.Click += new System.EventHandler(this.Combo_Click);
			// 
			// fours
			// 
			this.fours.Location = new System.Drawing.Point(267, 85);
			this.fours.Name = "fours";
			this.fours.Size = new System.Drawing.Size(126, 20);
			this.fours.TabIndex = 3;
			this.fours.Text = "0";
			this.fours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.fours.Click += new System.EventHandler(this.Combo_Click);
			// 
			// fives
			// 
			this.fives.Location = new System.Drawing.Point(267, 106);
			this.fives.Name = "fives";
			this.fives.Size = new System.Drawing.Size(126, 20);
			this.fives.TabIndex = 3;
			this.fives.Text = "0";
			this.fives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.fives.Click += new System.EventHandler(this.Combo_Click);
			// 
			// sixes
			// 
			this.sixes.Location = new System.Drawing.Point(267, 127);
			this.sixes.Name = "sixes";
			this.sixes.Size = new System.Drawing.Size(126, 20);
			this.sixes.TabIndex = 3;
			this.sixes.Text = "0";
			this.sixes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.sixes.Click += new System.EventHandler(this.Combo_Click);
			// 
			// threeKind
			// 
			this.threeKind.Location = new System.Drawing.Point(267, 232);
			this.threeKind.Name = "threeKind";
			this.threeKind.Size = new System.Drawing.Size(126, 20);
			this.threeKind.TabIndex = 3;
			this.threeKind.Text = "0";
			this.threeKind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.threeKind.Click += new System.EventHandler(this.Combo_Click);
			// 
			// fourKind
			// 
			this.fourKind.Location = new System.Drawing.Point(267, 253);
			this.fourKind.Name = "fourKind";
			this.fourKind.Size = new System.Drawing.Size(126, 20);
			this.fourKind.TabIndex = 3;
			this.fourKind.Text = "0";
			this.fourKind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.fourKind.Click += new System.EventHandler(this.Combo_Click);
			// 
			// fullHouse
			// 
			this.fullHouse.Location = new System.Drawing.Point(267, 274);
			this.fullHouse.Name = "fullHouse";
			this.fullHouse.Size = new System.Drawing.Size(126, 20);
			this.fullHouse.TabIndex = 3;
			this.fullHouse.Text = "0";
			this.fullHouse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.fullHouse.Click += new System.EventHandler(this.Combo_Click);
			// 
			// smStraight
			// 
			this.smStraight.Location = new System.Drawing.Point(267, 295);
			this.smStraight.Name = "smStraight";
			this.smStraight.Size = new System.Drawing.Size(126, 20);
			this.smStraight.TabIndex = 3;
			this.smStraight.Text = "0";
			this.smStraight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.smStraight.Click += new System.EventHandler(this.Combo_Click);
			// 
			// lgStraight
			// 
			this.lgStraight.Location = new System.Drawing.Point(267, 316);
			this.lgStraight.Name = "lgStraight";
			this.lgStraight.Size = new System.Drawing.Size(126, 20);
			this.lgStraight.TabIndex = 3;
			this.lgStraight.Text = "0";
			this.lgStraight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lgStraight.Click += new System.EventHandler(this.Combo_Click);
			// 
			// fiveKind
			// 
			this.fiveKind.Location = new System.Drawing.Point(267, 337);
			this.fiveKind.Name = "fiveKind";
			this.fiveKind.Size = new System.Drawing.Size(126, 20);
			this.fiveKind.TabIndex = 3;
			this.fiveKind.Text = "0";
			this.fiveKind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.fiveKind.Click += new System.EventHandler(this.Combo_Click);
			// 
			// chance
			// 
			this.chance.Location = new System.Drawing.Point(267, 358);
			this.chance.Name = "chance";
			this.chance.Size = new System.Drawing.Size(126, 20);
			this.chance.TabIndex = 3;
			this.chance.Text = "0";
			this.chance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chance.Click += new System.EventHandler(this.Combo_Click);
			// 
			// gamePanel
			// 
			this.gamePanel.Controls.Add(this.move);
			this.gamePanel.Controls.Add(this.label2);
			this.gamePanel.Controls.Add(this.exitButton);
			this.gamePanel.Controls.Add(this.rollButton);
			this.gamePanel.Controls.Add(this.table);
			this.gamePanel.Controls.Add(this.dicePanel);
			this.gamePanel.Location = new System.Drawing.Point(0, 0);
			this.gamePanel.Name = "gamePanel";
			this.gamePanel.Size = new System.Drawing.Size(518, 516);
			this.gamePanel.TabIndex = 3;
			// 
			// exitButton
			// 
			this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.exitButton.Location = new System.Drawing.Point(435, 471);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 35);
			this.exitButton.TabIndex = 5;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// dicePanel
			// 
			this.dicePanel.Controls.Add(this.dice1);
			this.dicePanel.Controls.Add(this.dice2);
			this.dicePanel.Controls.Add(this.dice3);
			this.dicePanel.Controls.Add(this.dice4);
			this.dicePanel.Controls.Add(this.dice5);
			this.dicePanel.Location = new System.Drawing.Point(0, 0);
			this.dicePanel.Name = "dicePanel";
			this.dicePanel.Size = new System.Drawing.Size(104, 447);
			this.dicePanel.TabIndex = 4;
			// 
			// dice1
			// 
			this.dice1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.dice1.Location = new System.Drawing.Point(10, 12);
			this.dice1.Name = "dice1";
			this.dice1.Size = new System.Drawing.Size(80, 80);
			this.dice1.TabIndex = 3;
			this.dice1.Click += new System.EventHandler(this.Dice_Click);
			// 
			// dice2
			// 
			this.dice2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.dice2.Location = new System.Drawing.Point(10, 98);
			this.dice2.Name = "dice2";
			this.dice2.Size = new System.Drawing.Size(80, 80);
			this.dice2.TabIndex = 3;
			this.dice2.Click += new System.EventHandler(this.Dice_Click);
			// 
			// dice3
			// 
			this.dice3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.dice3.Location = new System.Drawing.Point(10, 184);
			this.dice3.Name = "dice3";
			this.dice3.Size = new System.Drawing.Size(80, 80);
			this.dice3.TabIndex = 3;
			this.dice3.Click += new System.EventHandler(this.Dice_Click);
			// 
			// dice4
			// 
			this.dice4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.dice4.Location = new System.Drawing.Point(10, 270);
			this.dice4.Name = "dice4";
			this.dice4.Size = new System.Drawing.Size(80, 80);
			this.dice4.TabIndex = 3;
			this.dice4.Click += new System.EventHandler(this.Dice_Click);
			// 
			// dice5
			// 
			this.dice5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.dice5.Location = new System.Drawing.Point(10, 356);
			this.dice5.Name = "dice5";
			this.dice5.Size = new System.Drawing.Size(80, 80);
			this.dice5.TabIndex = 3;
			this.dice5.Click += new System.EventHandler(this.Dice_Click);
			// 
			// startPanel
			// 
			this.startPanel.Controls.Add(this.playButton);
			this.startPanel.Controls.Add(this.CheatingCheckBox);
			this.startPanel.Location = new System.Drawing.Point(0, 0);
			this.startPanel.Name = "startPanel";
			this.startPanel.Size = new System.Drawing.Size(515, 525);
			this.startPanel.TabIndex = 4;
			// 
			// playButton
			// 
			this.playButton.BackColor = System.Drawing.Color.Gold;
			this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.playButton.Location = new System.Drawing.Point(205, 218);
			this.playButton.Name = "playButton";
			this.playButton.Size = new System.Drawing.Size(106, 44);
			this.playButton.TabIndex = 1;
			this.playButton.Text = "Play";
			this.playButton.UseVisualStyleBackColor = false;
			this.playButton.Click += new System.EventHandler(this.PlayButton_Click);
			// 
			// CheatingCheckBox
			// 
			this.CheatingCheckBox.AutoSize = true;
			this.CheatingCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CheatingCheckBox.Location = new System.Drawing.Point(205, 278);
			this.CheatingCheckBox.Name = "CheatingCheckBox";
			this.CheatingCheckBox.Size = new System.Drawing.Size(104, 28);
			this.CheatingCheckBox.TabIndex = 0;
			this.CheatingCheckBox.Text = "Cheating";
			this.CheatingCheckBox.UseVisualStyleBackColor = true;
			// 
			// endPanel
			// 
			this.endPanel.Controls.Add(this.finishButton);
			this.endPanel.Controls.Add(this.result);
			this.endPanel.Controls.Add(this.label);
			this.endPanel.Location = new System.Drawing.Point(0, 0);
			this.endPanel.Name = "endPanel";
			this.endPanel.Size = new System.Drawing.Size(509, 522);
			this.endPanel.TabIndex = 2;
			// 
			// finishButton
			// 
			this.finishButton.BackColor = System.Drawing.Color.Gold;
			this.finishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.finishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.finishButton.Location = new System.Drawing.Point(206, 272);
			this.finishButton.Name = "finishButton";
			this.finishButton.Size = new System.Drawing.Size(100, 39);
			this.finishButton.TabIndex = 2;
			this.finishButton.Text = "finish";
			this.finishButton.UseVisualStyleBackColor = false;
			this.finishButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// result
			// 
			this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.result.Location = new System.Drawing.Point(10, 192);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(492, 37);
			this.result.TabIndex = 1;
			this.result.Text = "0";
			this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label.ForeColor = System.Drawing.Color.Gold;
			this.label.Location = new System.Drawing.Point(196, 155);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(122, 31);
			this.label.TabIndex = 0;
			this.label.Text = "RESULT";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(117, 453);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Move:";
			// 
			// move
			// 
			this.move.AutoSize = true;
			this.move.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.move.Location = new System.Drawing.Point(170, 453);
			this.move.Name = "move";
			this.move.Size = new System.Drawing.Size(31, 20);
			this.move.TabIndex = 7;
			this.move.Text = "0/3";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(517, 531);
			this.Controls.Add(this.startPanel);
			this.Controls.Add(this.gamePanel);
			this.Controls.Add(this.endPanel);
			this.Name = "Form1";
			this.Text = "Dice game";
			this.table.ResumeLayout(false);
			this.gamePanel.ResumeLayout(false);
			this.gamePanel.PerformLayout();
			this.dicePanel.ResumeLayout(false);
			this.startPanel.ResumeLayout(false);
			this.startPanel.PerformLayout();
			this.endPanel.ResumeLayout(false);
			this.endPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Button rollButton;
		private System.Windows.Forms.TableLayoutPanel table;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label player;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label sum;
		private System.Windows.Forms.Label bonus;
		private System.Windows.Forms.Label total;
		private System.Windows.Forms.Label twos;
		private System.Windows.Forms.Label ones;
		private System.Windows.Forms.Label threes;
		private System.Windows.Forms.Label fours;
		private System.Windows.Forms.Label fives;
		private System.Windows.Forms.Label sixes;
		private System.Windows.Forms.Label threeKind;
		private System.Windows.Forms.Label fourKind;
		private System.Windows.Forms.Label fullHouse;
		private System.Windows.Forms.Label smStraight;
		private System.Windows.Forms.Label lgStraight;
		private System.Windows.Forms.Label fiveKind;
		private System.Windows.Forms.Label chance;
		private System.Windows.Forms.Panel gamePanel;
		private System.Windows.Forms.Panel dice5;
		private System.Windows.Forms.Panel dice4;
		private System.Windows.Forms.Panel dice3;
		private System.Windows.Forms.Panel dice2;
		private System.Windows.Forms.Panel dice1;
		private System.Windows.Forms.Panel dicePanel;
		private System.Windows.Forms.Panel startPanel;
		private System.Windows.Forms.CheckBox CheatingCheckBox;
		private System.Windows.Forms.Button playButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Panel endPanel;
		private System.Windows.Forms.Button finishButton;
		private System.Windows.Forms.Label result;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Label move;
		private System.Windows.Forms.Label label2;
	}
}

