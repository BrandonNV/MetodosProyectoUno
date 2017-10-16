using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodosProyectoUno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(semilla.Text) || semilla.Text.Any(Char.IsLetter) ||
                string.IsNullOrWhiteSpace(multiplicador.Text) || multiplicador.Text.Any(Char.IsLetter) || 
                string.IsNullOrWhiteSpace(incremento.Text) || incremento.Text.Any(Char.IsLetter) ||
                string.IsNullOrWhiteSpace(modulo.Text) || modulo.Text.Any(Char.IsLetter) ||
                string.IsNullOrWhiteSpace(veces.Text) || veces.Text.Any(Char.IsLetter)
                )
            {
                MessageBox.Show("Favor de ingresar únicamente valores númericos");
            }
            else
            {
                dataGridView1.Rows.Clear();
                string[] rows = new string[300];
                int s = int.Parse(semilla.Text);
                int mu = int.Parse(multiplicador.Text);
                int i = int.Parse(incremento.Text);
                int mo = int.Parse(modulo.Text);
                int n = int.Parse(veces.Text);
                //int s = 4;
                //int  mu = 5;
                //int i = 7;
                //int mo = 8;
                double convert = 0;
                string temp;


                for (int a = 0; a < n; a++)
                {

                    rows[0] = s.ToString();
                    convert = Convert.ToDouble(mu * s + i);
                    temp = (convert / 8).ToString() + ".";
                    string[] operacion = temp.Split('.');
                    if (operacion[1] != "") operacion[1] = " + ." + operacion[1];
                    rows[1] = operacion[0] + "" + operacion[1];
                    rows[2] = (convert % 8).ToString();
                    rows[3] = ((convert % 8) / 8).ToString();
                    dataGridView1.Rows.Add(rows);
                    s = (mu * s + i) % mo;

                }

            }

        }
    }
}
