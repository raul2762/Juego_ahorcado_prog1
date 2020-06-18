using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_ahorcado_prog1
{
	public partial class Form1 : Form
	{
		List<string> AnimalesList = new List<string>();
		List<string> FrutasList = new List<string>();
		List<string> MarcaCarrosList = new List<string>();
		List<string> nombreBtn = new List<string>();
		int contador = 0;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			#region Lista Letras
			nombreBtn.Add("A");
			nombreBtn.Add("B");
			nombreBtn.Add("C");
			nombreBtn.Add("D");
			nombreBtn.Add("E");
			nombreBtn.Add("F");
			nombreBtn.Add("G");
			nombreBtn.Add("H");
			nombreBtn.Add("I");
			nombreBtn.Add("J");
			nombreBtn.Add("K");
			nombreBtn.Add("L");
			nombreBtn.Add("M");
			nombreBtn.Add("N");
			nombreBtn.Add("Ñ");
			nombreBtn.Add("O");
			nombreBtn.Add("P");
			nombreBtn.Add("Q");
			nombreBtn.Add("R");
			nombreBtn.Add("S");
			nombreBtn.Add("T");
			nombreBtn.Add("U");
			nombreBtn.Add("V");
			nombreBtn.Add("W");
			nombreBtn.Add("X");
			nombreBtn.Add("Y");
			nombreBtn.Add("Z");
			#endregion

			#region Lista Animales
			AnimalesList.Add("leon");
			AnimalesList.Add("cangrejo");
			AnimalesList.Add("canguro");
			AnimalesList.Add("bisonte");
			AnimalesList.Add("elefante");
			AnimalesList.Add("foca");
			AnimalesList.Add("jabali");
			AnimalesList.Add("loro");
			AnimalesList.Add("ciervo");
			AnimalesList.Add("bufalo");
			#endregion

			#region Lista Frutas
			FrutasList.Add("arandano");
			FrutasList.Add("cereza");
			FrutasList.Add("ciruela");
			FrutasList.Add("fresa");
			FrutasList.Add("mandarina");
			FrutasList.Add("melon");
			FrutasList.Add("kiwi");
			FrutasList.Add("coco");
			FrutasList.Add("manzana");
			FrutasList.Add("uva");
			#endregion

			#region Lista Marca de Carros
			MarcaCarrosList.Add("skoda");
			MarcaCarrosList.Add("seat");
			MarcaCarrosList.Add("bently");
			MarcaCarrosList.Add("citroen");
			MarcaCarrosList.Add("renault");
			MarcaCarrosList.Add("suzuki");
			MarcaCarrosList.Add("lotus");
			MarcaCarrosList.Add("lexus");
			MarcaCarrosList.Add("tesla");
			MarcaCarrosList.Add("volvo");
			#endregion

			comboBox1.Items.Add("Seleccione una categoria");
			comboBox1.Items.Add("Animales");
			comboBox1.Items.Add("Frutas");
			comboBox1.Items.Add("Marca de Carros");
			comboBox1.SelectedIndex = 0;
			timer1.Start();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Has hecho click en el Boton");
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			
		}

		private void handlerComun_Click(object sender, EventArgs e)
		{
			MessageBox.Show(((Button)sender).Text);
			btnContainer1.Controls.Remove(((Button)sender));
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (contador < nombreBtn.Count)
			{
				Button button = new Button();

				button.Height = 23;
				button.Width = 29;
				button.Name = nombreBtn[contador];
				button.Text = nombreBtn[contador];
				button.Click += new EventHandler(handlerComun_Click);
				btnContainer1.Controls.Add(button);
				contador++;
			}
			else
			{
				timer1.Stop();
			}
			
		}
	}
}
