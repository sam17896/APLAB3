using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APLab_3
{
    public partial class Form1 : Form
    {
        Color cl;
        public Form1()
        {
            InitializeComponent();
            button3.Hide();
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    c.Hide();
                    c.Text = "";
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right){
                contextMenuStrip1.Show(this,e.Location.X,e.Location.Y);
                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                cl = cd.Color;
            }
            int i = 0;
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = c as CheckBox;
                    if (cb.Checked)
                    {
                        if (c.Name == "checkBox1")
                        {
                            textBox1.ForeColor = cl;
                        }
                        if (c.Name == "checkBox2")
                        {
                            textBox2.ForeColor = cl;
                        }
                        if (c.Name == "checkBox3")
                        {
                            comboBox1.ForeColor = cl;
                        }
                        if (c.Name == "checkBox4")
                        {
                            textBox3.ForeColor = cl;
                        }
                        if (c.Name == "checkBox5")
                        {
                            dateTimePicker1.CalendarForeColor = cl;
                        }
                        if (c.Name == "checkBox6")
                        {
                            maskedTextBox1.ForeColor = cl;
                        }
                        i++;
                    }
                }
            }
            button3.Hide();
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    c.Hide();
                }
            }
        }

        private void changeFontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3.Show();
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    c.Show();
                }
            }
        }

        

    }
}
