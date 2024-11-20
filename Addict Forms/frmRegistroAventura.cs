using Mestre_de_Rpg.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mestre_de_Rpg
{
    public partial class frmRegistroAventura : Form
    {
        public frmRegistroAventura()
        {
            InitializeComponent();
        }

        public void CadastraAventura()
        {
            string NomeAventura = textBox1.Text;
            Aventura aventura = new Aventura(NomeAventura);
            aventura.RegistraAventura();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastraAventura();
            if(MessageBox.Show("Aventura Cadastrada!", "Mestre RPG", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                textBox1.Text = "";
            }
        }
    }
}
