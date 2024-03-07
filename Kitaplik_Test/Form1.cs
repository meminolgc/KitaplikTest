using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitaplik_Test
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		KitapDb Dbsinif = new KitapDb();

		private void button1_Click(object sender, EventArgs e)
		{
			 dataGridView1.DataSource = Dbsinif.Liste();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Kitap ktpSinif = new Kitap();	
			ktpSinif.Adı = textBox1.Text;
			ktpSinif.Yazarı = textBox2.Text;
			Dbsinif.KitapEkle(ktpSinif);
			MessageBox.Show("Kitap Eklendi");
		}
	}
}
