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

namespace David19
{
    public partial class FrmPal : Form
    {
        public FrmPal()
        {
            InitializeComponent();
            BarraID.MaxLength = 10;
            BarraTelefono.MaxLength = 10;
        }

        private void ButOk_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Butcancel_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void BarraTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void BarraNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButOk_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Butcancel_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void BarraID_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                {

                }
                else if (e.KeyChar == (char)Keys.Enter)
                {
                    MessageBox.Show("Presionaste enter!");
                    BarraNombre.Focus();
                }
                else
                {
                    MessageBox.Show("Por favor, escribir número, no letras");
                    e.Handled = true;
                }
            }

        }

        private void BarraNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {

            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show("Presionaste enter!");
                BarraApelldo.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, escribir solo letras, no números");
                e.Handled = true;
            }
        }

        private void BarraApelldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {

            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show("Presionaste enter!");
                BarraTelefono.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, escribir solo letras, no números");
                e.Handled = true;
            }
        }

        private void BarraTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                {

                }
                else if (e.KeyChar == (char)Keys.Enter)
                {
                    MessageBox.Show("Presionaste enter!");
                    BarraCorreo.Focus();
                }
                else
                {
                    MessageBox.Show("Por favor, escribir número, no letras");
                    e.Handled = true;
                }
            }
        }

        private void BarraCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MessageBox.Show("Presionaste enter!");
                ButOk.Focus();
            }
        }

        private void ButOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HAZ TERMINADO EL FORMULARIO!");
        }



        private void Butcancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Regresando al inicio del formulario");

            BarraID.Text = "";
            BarraNombre.Text = "";
            BarraApelldo.Text = "";
            BarraTelefono.Text = "";
            BarraCorreo.Text = "";
            BarraID.Focus();
        }

    }
}
