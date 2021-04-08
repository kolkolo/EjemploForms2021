using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EjemploForms2021
{
	public partial class PanelPrincipal : Form
	{
		public PanelPrincipal()
		{
			InitializeComponent();
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			Application.Exit();
		}
		private void PanelPrincipal_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			SubPanel1 subPana1 = new SubPanel1();
			subPana1.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SubPanel2 subPana2 = new SubPanel2();
			subPana2.Show();
		}
	}
}
