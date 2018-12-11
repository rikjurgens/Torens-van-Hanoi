using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorensVanHanoi
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}


		
		private void buttonForLoop_Click(object sender, EventArgs e)
		{

			//FOR-Loop Methode

			int input;
			double moves = 1;

			bool isnumber = int.TryParse(textBoxCountOne.Text, out input);
			
			if (isnumber == true && (input > 0 && input <= 64))
			{
				for (int i = 1; i < input; i++)
				{
					moves = moves * 2 + 1;
				}
				labelAnswerThree.Text = moves.ToString();
			}

			else
			{
				MessageBox.Show("Geen geldige invoer.");
			}
		}


		//Machtsverheffen Methode

		private void buttonPower_Click(object sender, EventArgs e)
		{
			double input;
			double.TryParse(textBoxCountOne.Text, out input);
			var result = Math.Pow(2, input) - 1;
			labelAnswerThree.Text = string.Format("{0}", result);
		}

		//Recursie Methode
	}
}
