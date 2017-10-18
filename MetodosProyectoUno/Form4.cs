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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(semilla.Text) || semilla.Text.Any(Char.IsLetter) ||
                string.IsNullOrWhiteSpace(multiplicador.Text) || multiplicador.Text.Any(Char.IsLetter) ||
                string.IsNullOrWhiteSpace(modulo.Text) || modulo.Text.Any(Char.IsLetter) ||
                string.IsNullOrWhiteSpace(veces.Text) || veces.Text.Any(Char.IsLetter)
                )
            {
                MessageBox.Show("Favor de ingresar únicamente valores númericos");
            }
            else {
                dataGridView1.Rows.Clear();
                string[] rows = new string[300];
                int s = int.Parse(semilla.Text);
                int mu = int.Parse(multiplicador.Text);
                int mo = int.Parse(modulo.Text);
                int n = int.Parse(veces.Text);
                double convert = 0;
                string temp;
                if ((s >= 0 && mu >= 0 && mo >= 0) && (mo > mu && mo > s))
                {
                    for (int a = 0; a < n; a++)
                    {
                        rows[0] = s.ToString();
                        convert = Convert.ToDouble(mu * s);
                        temp = (convert / mo).ToString() + ".";
                        string[] operacion = temp.Split('.');
                        if (operacion[1] != "")
                        {
                            operacion[1] = " + ." + operacion[1];
                        }
                        rows[1] = operacion[0] + "" + operacion[1];
                        rows[2] = (convert % mo).ToString();
                        rows[3] = ((convert % mo) / mo).ToString();
                        dataGridView1.Rows.Add(rows);
                        s = (mu * s) % mo;
                    }
                }
                else {
                    MessageBox.Show("Valores númericos NO cumplen los requisitos:" +
                                    "\n\r -Semilla, Multiplicador, Módulo >= 0" +
                                    "\n\r -Módulo > Multiplicador" +
                                    "\n\r -Módulo > Semilla");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void semilla_TextChanged(object sender, EventArgs e)
        {

        }

        private void multiplicador_TextChanged(object sender, EventArgs e)
        {

        }

        private void modulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void veces_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
