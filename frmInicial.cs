using Mestre_de_Rpg.Entities.Dices;
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
    public partial class frmInicial : Form
    {
        public NumericUpDown[] quantidadeDados;

        public frmInicial()
        {
            InitializeComponent();
            quantidadeDados = new NumericUpDown[]
            {
                nUDd4,
                nUDd6,
                nUDd8,
                nUDd10,
                nUDd12,
                nUDd20,
                nUDd100
            };
        }

        private void Dice_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Name)
                {
                    case "d4":
                        nUDd4.Value += 1;
                        break;
                    case "d6":
                        nUDd6.Value += 1;
                        break;
                    case "d8":
                        nUDd8.Value += 1;
                        break;
                    case "d10":
                        nUDd10.Value += 1;
                        break;
                    case "d12":
                        nUDd12.Value += 1;
                        break;
                    case "d20":
                        nUDd20.Value += 1;
                        break;
                    case "d100":
                        nUDd100.Value += 1;
                        break;
                }
            }
        }

        private void btnRolar_Click(object sender, EventArgs e)
        {
            foreach (NumericUpDown qtdados in quantidadeDados)
            {
                if (qtdados.Value > 0) 
                {
                    //lbValorResultado.Text = RolarDado((int)nUDd4.Value).ToString();
                }
            }
        }
    }
}
