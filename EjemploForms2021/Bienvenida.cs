using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploForms2021
{
	public partial class Bienvenida : Form
	{
		public Bienvenida()
		{
			InitializeComponent();
		}


		private void Bienvenida_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			//Ocultamos la previa

			this.Hide();

			//Mostramos la nueva

			PanelPrincipal panelPrincipal = new PanelPrincipal();
			panelPrincipal.Show();
		}
	}
}
