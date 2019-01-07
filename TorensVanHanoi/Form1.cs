using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Numerics;
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
			BigInteger moves = 1;

			bool isnumber = int.TryParse(textBoxCountOne.Text, out input);

			if (isnumber == true && (input > 0 && input <=64))
			{
				for (int i = 1; i < input; i++)
				{
					moves = moves * 2 + 1;
				}

				labelAnswerThree.Text = string.Format("{0} stappen", moves.ToString());

				//Tijdsberekening

				//TIJD: EEUW

				BigInteger eeuw = moves % 3153600000; //Dit is het restgetal (schuift het door naar de volgende berekening, in dit geval: JAAR)
				BigInteger deeltijdEeuw = moves - eeuw; //Dit is een deelberekening (tussenberekening)
				BigInteger eindEeuw = deeltijdEeuw / 3153600000; //Dit is het eindantwoord (gaat naar label)
				mileniaCount.Text = eindEeuw.ToString();

				//TIJD: JAAR

				BigInteger jaar = eeuw % 31536000; //Dit is het restgetal (schuift het door naar de volgende berekening, in dit geval: MAANDEN)
				BigInteger deeltijdJaar = eeuw - jaar; //Dit is een deelberekening (tussenberekening)
				BigInteger eindJaar = deeltijdJaar / 31536000; //Dit is het eindantwoord (gaat naar label)
				yearCount.Text = eindJaar.ToString();

				//TIJD: MAANDEN

				BigInteger maanden = jaar % 2628000; //Dit is het restgetal (schuift het door naar de volgende berekening, in dit geval: DAGEN)
				BigInteger deeltijdMaanden = jaar - maanden; //Dit is een deelberekening (tussenberekening)
				BigInteger eindMaand = deeltijdMaanden / 2628000; //Dit is het eindantwoord (gaat naar label)

				//TIJD: DAGEN

				BigInteger dagen = jaar % 86400; //Dit is het restgetal (schuift het door naar de volgende berekening, in dit geval: UREN)
				BigInteger deeltijdDagen = jaar - dagen; //Dit is een deelberekening (tussenberekening)
				BigInteger eindDagen = deeltijdDagen / 86400; //Dit is het eindantwoord (gaat naar label)
				dayCount.Text = eindDagen.ToString();

				//TIJD: UREN

				BigInteger uren = dagen % 3600;  //Dit is het restgetal (schuift het door naar de volgende berekening, in dit geval: MINUTEN)
				BigInteger deeltijdUren = dagen - uren; //Dit is een deelberekening (tussenberekening)
				BigInteger eindUren = deeltijdUren / 3600; //Dit is het eindantwoord (gaat naar label)
				hourCount.Text = eindUren.ToString();

				//TIJD: MINUTEN

				BigInteger minuten = uren % 60;  //Dit is het restgetal (schuift het door naar de volgende berekening, in dit geval: SECONDEN)
				BigInteger deeltijdMinuten = uren - minuten; //Dit is een deelberekening (tussenberekening)
				BigInteger eindMinuten = deeltijdMinuten / 60; //Dit is het eindantwoord (gaat naar label)
				minuteCount.Text = eindMinuten.ToString();

				//TIJD: SECONDEN

				secondCount.Text = minuten.ToString();

			}

			else
			{
				MessageBox.Show("Geen geldige invoer.");
			}

			
		}


		//Machtsverheffen Methode

		private void buttonPower_Click(object sender, EventArgs e)
		{
			try
			{
				ulong number;
				ulong result = 0;

				number = ulong.Parse(textBoxCountOne.Text);

				if (number >= 1 && number <= 64)
				{
					result = (ulong)Math.Pow(2, number) - 1;

					labelAnswerThree.Text = string.Format("{0} stappen", result.ToString());


					//Tijdsberekening

					//TIJD: EEUW

					BigInteger eeuw = result % 3153600000; //Dit is het restgetal (schuift het door naar de volgende berekening, in dit geval: JAAR)
					BigInteger deeltijdEeuw = result - eeuw; //Dit is een deelberekening (tussenberekening)
					BigInteger eindEeuw = deeltijdEeuw / 3153600000; //Dit is het eindantwoord (gaat naar label)
					mileniaCount.Text = eindEeuw.ToString();

					//TIJD: JAAR

					BigInteger jaar = eeuw % 31536000; //Dit is het restgetal (schuift het door naar de volgende berekening, in dit geval: MAANDEN)
					BigInteger deeltijdJaar = eeuw - jaar; //Dit is een deelberekening (tussenberekening)
					BigInteger eindJaar = deeltijdJaar / 31536000; //Dit is het eindantwoord (gaat naar label)
					yearCount.Text = eindJaar.ToString();

					//TIJD: MAANDEN

					BigInteger maanden = jaar % 2628000; //Dit is het restgetal (schuift het door naar de volgende berekening, in dit geval: DAGEN)
					BigInteger deeltijdMaanden = jaar - maanden; //Dit is een deelberekening (tussenberekening)
					BigInteger eindMaand = deeltijdMaanden / 2628000; //Dit is het eindantwoord (gaat naar label)

					//TIJD: DAGEN

					BigInteger dagen = jaar % 86400; //Dit is het restgetal (schuift het door naar de volgende berekening, in dit geval: UREN)
					BigInteger deeltijdDagen = jaar - dagen; //Dit is een deelberekening (tussenberekening)
					BigInteger eindDagen = deeltijdDagen / 86400; //Dit is het eindantwoord (gaat naar label)
					dayCount.Text = eindDagen.ToString();

					//TIJD: UREN

					BigInteger uren = dagen % 3600;  //Dit is het restgetal (schuift het door naar de volgende berekening, in dit geval: MINUTEN)
					BigInteger deeltijdUren = dagen - uren; //Dit is een deelberekening (tussenberekening)
					BigInteger eindUren = deeltijdUren / 3600; //Dit is het eindantwoord (gaat naar label)
					hourCount.Text = eindUren.ToString();

					//TIJD: MINUTEN

					BigInteger minuten = uren % 60;  //Dit is het restgetal (schuift het door naar de volgende berekening, in dit geval: SECONDEN)
					BigInteger deeltijdMinuten = uren - minuten; //Dit is een deelberekening (tussenberekening)
					BigInteger eindMinuten = deeltijdMinuten / 60; //Dit is het eindantwoord (gaat naar label)
					minuteCount.Text = eindMinuten.ToString();

					//TIJD: SECONDEN

					secondCount.Text = minuten.ToString();

				}

				else
				{
					MessageBox.Show("Geen geldige invoer!");
				}

			}

			catch (ArgumentNullException)
			{
				MessageBox.Show("Geen geldige invoer!");
			}

			catch (System.FormatException)

			{
				MessageBox.Show("Geen geldige invoer!");
			}

		}


		//Recursie Methode

		private void buttonRecursie_Click(object sender, EventArgs e)
		{
			ulong schijven;
			bool gelukt = ulong.TryParse(textBoxCountOne.Text, out schijven);

			if (!gelukt)
			{
				
			}

			else
			{
				ulong result = count (0, 1, schijven);
				labelAnswerThree.Text = string.Format("{0} stappen", result);

				//Tijdsberekening

				//TIJD: EEUW

				BigInteger eeuw = result % 3153600000; //Dit is het restgetal (schuift het door naar de volgende berekening, in dit geval: JAAR)
				BigInteger deeltijdEeuw = result - eeuw; //Dit is een deelberekening (tussenberekening)
				BigInteger eindEeuw = deeltijdEeuw / 3153600000; //Dit is het eindantwoord (gaat naar label)
				mileniaCount.Text = eindEeuw.ToString();

				//TIJD: JAAR

				BigInteger jaar = eeuw % 31536000; //Dit is het restgetal (schuift het door naar de volgende berekening, in dit geval: MAANDEN)
				BigInteger deeltijdJaar = eeuw - jaar; //Dit is een deelberekening (tussenberekening)
				BigInteger eindJaar = deeltijdJaar / 31536000; //Dit is het eindantwoord (gaat naar label)
				yearCount.Text = eindJaar.ToString();

				//TIJD: MAANDEN

				BigInteger maanden = jaar % 2628000; //Dit is het restgetal (schuift het door naar de volgende berekening, in dit geval: DAGEN)
				BigInteger deeltijdMaanden = jaar - maanden; //Dit is een deelberekening (tussenberekening)
				BigInteger eindMaand = deeltijdMaanden / 2628000; //Dit is het eindantwoord (gaat naar label)

				//TIJD: DAGEN

				BigInteger dagen = jaar % 86400; //Dit is het restgetal (schuift het door naar de volgende berekening, in dit geval: UREN)
				BigInteger deeltijdDagen = jaar - dagen; //Dit is een deelberekening (tussenberekening)
				BigInteger eindDagen = deeltijdDagen / 86400; //Dit is het eindantwoord (gaat naar label)
				dayCount.Text = eindDagen.ToString();

				//TIJD: UREN

				BigInteger uren = dagen % 3600;  //Dit is het restgetal (schuift het door naar de volgende berekening, in dit geval: MINUTEN)
				BigInteger deeltijdUren = dagen - uren; //Dit is een deelberekening (tussenberekening)
				BigInteger eindUren = deeltijdUren / 3600; //Dit is het eindantwoord (gaat naar label)
				hourCount.Text = eindUren.ToString();

				//TIJD: MINUTEN

				BigInteger minuten = uren % 60;  //Dit is het restgetal (schuift het door naar de volgende berekening, in dit geval: SECONDEN)
				BigInteger deeltijdMinuten = uren - minuten; //Dit is een deelberekening (tussenberekening)
				BigInteger eindMinuten = deeltijdMinuten / 60; //Dit is het eindantwoord (gaat naar label)
				minuteCount.Text = eindMinuten.ToString();

				//TIJD: SECONDEN

				secondCount.Text = minuten.ToString();

			}
		}

		static ulong count(ulong zetten, ulong huidigeschijf, ulong schijven)
		{
			if (huidigeschijf > schijven)
			{
				return zetten;
			}
			else
			{
				zetten = zetten * 2 + 1;
				ulong resultaat = count(zetten, huidigeschijf + 1, schijven);

				return resultaat;
			}

			
			
		}


		//Button Clear
		private void buttonClear_Click(object sender, EventArgs e)
		{
			textBoxCountOne.Text = "";
			labelAnswerThree.Text = "";
			mileniaCount.Text = "0";
			yearCount.Text = "0";
			monthCount.Text = "0";
			dayCount.Text = "0";
			hourCount.Text = "0";
			minuteCount.Text = "0";
			secondCount.Text = "0";
		}

		
	}
}
