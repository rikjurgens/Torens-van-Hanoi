namespace TorensVanHanoi
{
	partial class MainForm
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
			this.labelQuestionOne = new System.Windows.Forms.Label();
			this.labelQuestionThree = new System.Windows.Forms.Label();
			this.buttonForLoop = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxCountOne = new System.Windows.Forms.TextBox();
			this.labelQuestionTwo = new System.Windows.Forms.Label();
			this.labelAnswerThree = new System.Windows.Forms.Label();
			this.labelQuestionFour = new System.Windows.Forms.Label();
			this.labelAnswerFour = new System.Windows.Forms.Label();
			this.buttonPower = new System.Windows.Forms.Button();
			this.buttonRecursie = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelQuestionOne
			// 
			this.labelQuestionOne.AutoSize = true;
			this.labelQuestionOne.Location = new System.Drawing.Point(46, 63);
			this.labelQuestionOne.Name = "labelQuestionOne";
			this.labelQuestionOne.Size = new System.Drawing.Size(213, 17);
			this.labelQuestionOne.TabIndex = 0;
			this.labelQuestionOne.Text = "1. Vul hier het aantal schijven in:";
			// 
			// labelQuestionThree
			// 
			this.labelQuestionThree.AutoSize = true;
			this.labelQuestionThree.Location = new System.Drawing.Point(46, 229);
			this.labelQuestionThree.Name = "labelQuestionThree";
			this.labelQuestionThree.Size = new System.Drawing.Size(260, 17);
			this.labelQuestionThree.TabIndex = 1;
			this.labelQuestionThree.Text = "3. Het aantal zetten dat je moet doen is:";
			// 
			// buttonForLoop
			// 
			this.buttonForLoop.Location = new System.Drawing.Point(72, 128);
			this.buttonForLoop.Name = "buttonForLoop";
			this.buttonForLoop.Size = new System.Drawing.Size(106, 61);
			this.buttonForLoop.TabIndex = 2;
			this.buttonForLoop.Text = "Resulataat (For-Loop)";
			this.buttonForLoop.UseVisualStyleBackColor = true;
			this.buttonForLoop.Click += new System.EventHandler(this.buttonForLoop_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(447, 349);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 17);
			this.label3.TabIndex = 3;
			// 
			// textBoxCountOne
			// 
			this.textBoxCountOne.Location = new System.Drawing.Point(265, 60);
			this.textBoxCountOne.Name = "textBoxCountOne";
			this.textBoxCountOne.Size = new System.Drawing.Size(100, 22);
			this.textBoxCountOne.TabIndex = 4;
			// 
			// labelQuestionTwo
			// 
			this.labelQuestionTwo.AutoSize = true;
			this.labelQuestionTwo.Location = new System.Drawing.Point(46, 149);
			this.labelQuestionTwo.Name = "labelQuestionTwo";
			this.labelQuestionTwo.Size = new System.Drawing.Size(20, 17);
			this.labelQuestionTwo.TabIndex = 5;
			this.labelQuestionTwo.Text = "2.";
			// 
			// labelAnswerThree
			// 
			this.labelAnswerThree.AutoSize = true;
			this.labelAnswerThree.Location = new System.Drawing.Point(307, 229);
			this.labelAnswerThree.Name = "labelAnswerThree";
			this.labelAnswerThree.Size = new System.Drawing.Size(0, 17);
			this.labelAnswerThree.TabIndex = 6;
			// 
			// labelQuestionFour
			// 
			this.labelQuestionFour.AutoSize = true;
			this.labelQuestionFour.Location = new System.Drawing.Point(46, 301);
			this.labelQuestionFour.Name = "labelQuestionFour";
			this.labelQuestionFour.Size = new System.Drawing.Size(167, 17);
			this.labelQuestionFour.TabIndex = 7;
			this.labelQuestionFour.Text = "4. Je doet hier ongeveer:";
			// 
			// labelAnswerFour
			// 
			this.labelAnswerFour.AutoSize = true;
			this.labelAnswerFour.Location = new System.Drawing.Point(219, 301);
			this.labelAnswerFour.Name = "labelAnswerFour";
			this.labelAnswerFour.Size = new System.Drawing.Size(0, 17);
			this.labelAnswerFour.TabIndex = 8;
			// 
			// buttonPower
			// 
			this.buttonPower.Location = new System.Drawing.Point(184, 128);
			this.buttonPower.Name = "buttonPower";
			this.buttonPower.Size = new System.Drawing.Size(106, 61);
			this.buttonPower.TabIndex = 9;
			this.buttonPower.Text = "Resulataat (Machtsverheffen)";
			this.buttonPower.UseVisualStyleBackColor = true;
			this.buttonPower.Click += new System.EventHandler(this.buttonPower_Click);
			// 
			// buttonRecursie
			// 
			this.buttonRecursie.Location = new System.Drawing.Point(296, 127);
			this.buttonRecursie.Name = "buttonRecursie";
			this.buttonRecursie.Size = new System.Drawing.Size(106, 61);
			this.buttonRecursie.TabIndex = 10;
			this.buttonRecursie.Text = "Resulataat (Recursie)";
			this.buttonRecursie.UseVisualStyleBackColor = true;
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(372, 57);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(75, 29);
			this.buttonClear.TabIndex = 11;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(479, 395);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonRecursie);
			this.Controls.Add(this.buttonPower);
			this.Controls.Add(this.labelAnswerFour);
			this.Controls.Add(this.labelQuestionFour);
			this.Controls.Add(this.labelAnswerThree);
			this.Controls.Add(this.labelQuestionTwo);
			this.Controls.Add(this.textBoxCountOne);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonForLoop);
			this.Controls.Add(this.labelQuestionThree);
			this.Controls.Add(this.labelQuestionOne);
			this.Name = "MainForm";
			this.Text = "De Torens van Hanoi";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelQuestionOne;
		private System.Windows.Forms.Label labelQuestionThree;
		private System.Windows.Forms.Button buttonForLoop;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxCountOne;
		private System.Windows.Forms.Label labelQuestionTwo;
		private System.Windows.Forms.Label labelAnswerThree;
		private System.Windows.Forms.Label labelQuestionFour;
		private System.Windows.Forms.Label labelAnswerFour;
		private System.Windows.Forms.Button buttonPower;
		private System.Windows.Forms.Button buttonRecursie;
		private System.Windows.Forms.Button buttonClear;
	}
}

