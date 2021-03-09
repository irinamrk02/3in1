using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3in1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calc calc = new Calc();
            calc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphic graph = new Graphic();
            graph.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Text text = new Text();
            text.Show();
        }
    }
}
