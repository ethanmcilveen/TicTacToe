namespace TicTacToe
{
	partial class GameForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblTitleInfo = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.BtnReset = new System.Windows.Forms.Button();
			this.BtnClear = new System.Windows.Forms.Button();
			this.BtnExit = new System.Windows.Forms.Button();
			this.LblXScore = new System.Windows.Forms.Label();
			this.LblOScore = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.Black;
			this.lblTitle.Location = new System.Drawing.Point(101, 9);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(199, 39);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Tic Tac Toe";
			this.lblTitle.Click += new System.EventHandler(this.ShowInfo);
			// 
			// lblTitleInfo
			// 
			this.lblTitleInfo.AutoSize = true;
			this.lblTitleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitleInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblTitleInfo.Location = new System.Drawing.Point(132, 48);
			this.lblTitleInfo.Name = "lblTitleInfo";
			this.lblTitleInfo.Size = new System.Drawing.Size(139, 15);
			this.lblTitleInfo.TabIndex = 1;
			this.lblTitleInfo.Text = "Click me for Instructions!";
			this.lblTitleInfo.Click += new System.EventHandler(this.ShowInfo);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(85, 140);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 55);
			this.label1.TabIndex = 2;
			this.label1.Text = "X";
			this.label1.Click += new System.EventHandler(this.TileClicked);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(165, 140);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 55);
			this.label2.TabIndex = 3;
			this.label2.Text = "X";
			this.label2.Click += new System.EventHandler(this.TileClicked);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(244, 140);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 55);
			this.label3.TabIndex = 4;
			this.label3.Text = "X";
			this.label3.Click += new System.EventHandler(this.TileClicked);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(85, 210);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 55);
			this.label4.TabIndex = 5;
			this.label4.Text = "X";
			this.label4.Click += new System.EventHandler(this.TileClicked);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(165, 210);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 55);
			this.label5.TabIndex = 6;
			this.label5.Text = "X";
			this.label5.Click += new System.EventHandler(this.TileClicked);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(244, 210);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 55);
			this.label6.TabIndex = 7;
			this.label6.Text = "X";
			this.label6.Click += new System.EventHandler(this.TileClicked);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(85, 285);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 55);
			this.label7.TabIndex = 8;
			this.label7.Text = "X";
			this.label7.Click += new System.EventHandler(this.TileClicked);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(165, 285);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 55);
			this.label8.TabIndex = 9;
			this.label8.Text = "X";
			this.label8.Click += new System.EventHandler(this.TileClicked);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(244, 285);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 55);
			this.label9.TabIndex = 10;
			this.label9.Text = "X";
			this.label9.Click += new System.EventHandler(this.TileClicked);
			// 
			// BtnReset
			// 
			this.BtnReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BtnReset.Location = new System.Drawing.Point(135, 405);
			this.BtnReset.Name = "BtnReset";
			this.BtnReset.Size = new System.Drawing.Size(108, 33);
			this.BtnReset.TabIndex = 11;
			this.BtnReset.Text = "Reset";
			this.BtnReset.UseVisualStyleBackColor = true;
			this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
			// 
			// BtnClear
			// 
			this.BtnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BtnClear.Location = new System.Drawing.Point(12, 405);
			this.BtnClear.Name = "BtnClear";
			this.BtnClear.Size = new System.Drawing.Size(108, 33);
			this.BtnClear.TabIndex = 12;
			this.BtnClear.Text = "Clear Score";
			this.BtnClear.UseVisualStyleBackColor = true;
			this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
			// 
			// BtnExit
			// 
			this.BtnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BtnExit.Location = new System.Drawing.Point(261, 405);
			this.BtnExit.Name = "BtnExit";
			this.BtnExit.Size = new System.Drawing.Size(108, 33);
			this.BtnExit.TabIndex = 13;
			this.BtnExit.Text = "Exit";
			this.BtnExit.UseVisualStyleBackColor = true;
			this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// LblXScore
			// 
			this.LblXScore.AutoSize = true;
			this.LblXScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblXScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.LblXScore.Location = new System.Drawing.Point(81, 84);
			this.LblXScore.Name = "LblXScore";
			this.LblXScore.Size = new System.Drawing.Size(79, 18);
			this.LblXScore.TabIndex = 14;
			this.LblXScore.Text = "X Score: ";
			// 
			// LblOScore
			// 
			this.LblOScore.AutoSize = true;
			this.LblOScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblOScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.LblOScore.Location = new System.Drawing.Point(224, 84);
			this.LblOScore.Name = "LblOScore";
			this.LblOScore.Size = new System.Drawing.Size(76, 18);
			this.LblOScore.TabIndex = 15;
			this.LblOScore.Text = "O Score:";
			// 
			// GameForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(381, 450);
			this.Controls.Add(this.LblOScore);
			this.Controls.Add(this.LblXScore);
			this.Controls.Add(this.BtnExit);
			this.Controls.Add(this.BtnClear);
			this.Controls.Add(this.BtnReset);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblTitleInfo);
			this.Controls.Add(this.lblTitle);
			this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "GameForm";
			this.Text = "Tic Tac Toe";
			this.Load += new System.EventHandler(this.GameForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblTitleInfo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button BtnReset;
		private System.Windows.Forms.Button BtnClear;
		private System.Windows.Forms.Button BtnExit;
		private System.Windows.Forms.Label LblXScore;
		private System.Windows.Forms.Label LblOScore;
	}
}

