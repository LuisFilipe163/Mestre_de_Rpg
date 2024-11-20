using Mestre_de_Rpg.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mestre_de_Rpg.Formularios_adicionais
{
    public partial class frmExcluirAventuras : Form
    {
        public frmExcluirAventuras()
        {
            InitializeComponent();
            CarregarAventurasNoMenu();
        }

        private void CarregarAventurasNoMenu()
        {
            listBox1.Items.Clear();
            DataTable aventuras = DALAventura.CarregaAventuras();
            foreach (DataRow row in aventuras.Rows)
            {
                string nomeAventura = row["nome"].ToString();
                listBox1.Items.Add(nomeAventura);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                // Obtém o nome da aventura selecionada
                string nomeAventura = listBox1.SelectedItem.ToString();

                // Obtém o id_aventura baseado no nome
                int idAventura = DALAventura.GetIdAventuraPorNome(nomeAventura);

                if (idAventura != -1)
                {
                    DALAventura.ExcluiAventura(idAventura);
                    CarregarAventurasNoMenu();
                }
                else
                {
                    MessageBox.Show("Aventura não encontrada.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma aventura para excluir.");
            }
        }
    }
}
