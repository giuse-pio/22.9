using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22._9
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmArea_Click(object sender, EventArgs e)
        {
            float Base=0, altezza=0;
            if(!float.TryParse(txtBase.Text, out Base))
            {
                lblArea.Text = "errore";
                lblArea.BackColor = Color.Tomato;
            }
            else if (!float.TryParse(txtAltezza.Text, out altezza))
            {
                lblArea.Text = "errore";
                lblArea.BackColor = Color.Tomato;
            }
            else
            {
                float area = (Base * altezza) / 2;
                lblArea.BackColor = Color.LightGreen;
                lblArea.Text = area.ToString();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AcceptButton=btmArea;
        }

        private void btmClear_Click(object sender, EventArgs e)
        {
            txtBase.Clear();
            txtAltezza.Clear();
        }
    }
}
