using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ArduinoPiano
{
	public partial class Form1 : Form
	{
		SerialPort serialPort1;
		public Form1()
		{
			InitializeComponent();
			KeyPreview = true;
			serialPort1 = new System.IO.Ports.SerialPort("COM3", 9600);
			serialPort1.Open();
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (e.KeyData == Keys.Escape)
			{
				label1.Text = "";
			}
		}
		
		private void button1_Click(object sender, EventArgs e)
		{
			serialPort1.Write("C");
			label1.Text += "ド";
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			serialPort1.Write("D");
			label1.Text += "レ";
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			serialPort1.Write("E");
			label1.Text += "ミ";
		}

		private void button4_Click_1(object sender, EventArgs e)
		{
			serialPort1.Write("F");
			label1.Text += "ファ";
		}

		private void button5_Click_1(object sender, EventArgs e)
		{
			serialPort1.Write("G");
			label1.Text += "ソ";
		}

		private void button6_Click(object sender, EventArgs e)
		{
			serialPort1.Write("A");
			label1.Text += "ラ";
		}

		private void button7_Click_1(object sender, EventArgs e)	//シ
		{
			serialPort1.Write("B");
			label1.Text += "シ";
		}

		private void button8_Click_1(object sender, EventArgs e)
		{
			serialPort1.Write("c");
			label1.Text += "ﾄﾞ";
		}
	}
}
