using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e) {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) {

        }

        private void timer1_Tick(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

            //MEU SEGUNDO PROJETO <3

            int resultado = 0;

            if (certo1.Checked == true) {
                resultado = resultado + 1;
            }

            if (certo2.Checked == true) {
                resultado = resultado + 1;
            }

            if (certo3.Checked == true) {
                resultado = resultado + 1;
            }

            pontuacao.Text = "Sua pontuação é: " + resultado.ToString();
        }
    }
}
