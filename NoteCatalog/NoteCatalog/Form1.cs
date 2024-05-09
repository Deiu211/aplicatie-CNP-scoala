using NoteCatalog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NoteCatalog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string falsPropozitie = "fals!! CNP-ul tau nu exista!!";
            Elev elev= new Elev();
            elev.setNume(txt_nume.Text);
            elev.setTata(txt_tata.Text);
            elev.setMama(txt_mama.Text);
            elev.setCNP(txt_cnp.Text);
            if (elev.getCNP().Length == 13)
                if (elev.verificareCNP(txt_cnp.Text)) MessageBox.Show("e bun!");
                else MessageBox.Show(falsPropozitie);
            else MessageBox.Show("nu are lungime");
            txt_cnp.Text=cmb_luna.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_cnp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
