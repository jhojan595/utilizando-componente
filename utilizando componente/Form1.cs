using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utilizando_componente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();

        }

        private void btnPlayer_Click(object sender, EventArgs e)
        {
            form2 frm = new form2();
            frm.ShowDialog();
        }

        private void btnNavegador_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.ShowDialog();

        }
    }
}
