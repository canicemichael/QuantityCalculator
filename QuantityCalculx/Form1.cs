using System;
using System.Windows.Forms;
using System.Collections.Generic;


namespace QuantityCalculx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            //if (this.EffCsttb.Text != "")
            
            if(int.TryParse(this.EffCsttb.Text, out int space))
            {
                listBox1.Items.Add(this.EffCsttb.Text);
                this.EffCsttb.Focus();
                this.EffCsttb.Clear();
            }            
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach(object item in listBox1.Items)
            {
                sb.Append((double)Convert.ToInt32(Incometb.Text) / (listBox1.Items.Count * Convert.ToInt32(item)));
                sb.Append("\n");
                sb.Append("\n");
            }
            sb.ToString();
            int x = int.Parse(sb.ToString());
            listBox2.Items.Add(x);
            */
            //double sum = 0;
            listBox2.Items.Clear();

            List<double> sum = new List<double>();

            if(int.TryParse(Incometb.Text, out int cloud))
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    sum.Add(Convert.ToDouble(Incometb.Text) / (listBox1.Items.Count * Convert.ToDouble(listBox1.Items[i])));
                }
            }
            
            for (int j = 0; j < listBox1.Items.Count; j++)
            {
                listBox2.Items.Add("Xqty"+(j+1) +" = "+ sum[j]);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EffCsttb.Text = "";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            Incometb.Text = "";
        }

        private void EffCsttb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                button1_Click(this, new EventArgs());
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Incometb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                button3_Click(this, new EventArgs());
                e.Handled = true;
            }
        }
    }
}
