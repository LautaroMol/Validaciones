using System.Security.Cryptography;

namespace ControlString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt.Text.Length == 2)
            {
                if (!(char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten letras y espacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
            if (txt.Text.Length > 2 && txt.Text.Length < 6)
            {
                if (txt.Text[2] == ' ')
                {
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                    {
                        MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        e.Handled = true;
                        return;
                    }
                }
                if (txt.Text.Length == 6 && txt.Text[2] == ' ')
                {
                    txt.MaxLength = 9;
                    if (!(e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back))
                    {
                        MessageBox.Show("Solo se permiten espacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        e.Handled = true;
                        return;
                    }
                }
                if (txt.Text.Length == 3 && char.IsLetter(txt.Text[2]))
                {
                    {
                        if (!(e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back))
                        {
                            MessageBox.Show("Solo se permiten espacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            e.Handled = true;
                            return;
                        }
                    }
                }
                else if (txt.Text.Length > 3 && txt.Text[3] == ' ')
                {
                    txt.MaxLength = 7;
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                    {
                        MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        e.Handled = true;
                        return;
                    }
                }
            }
            if (txt.Text.Length >= 7 && txt.Text[6] == ' ')
            {
                txt.MaxLength = 9;
                if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Length == 11) {
                string cuil = "";
                string dni = "";
                for (int i = 0; i < txtDni.Text.Length;i++)
                {
                    if (i == 2 || i == 10)
                    {
                        cuil += '-';
                        cuil += txtDni.Text[i]; 
                    }
                    else { cuil += txtDni.Text[i];}
                    if (i>1 && i < 10) { dni += txtDni.Text[i]; }
                }
                MessageBox.Show("el dni introducido es: " + cuil + " y el dni es: " + dni);
            }
            else MessageBox.Show("por favor coloque el numero correcto de caracteres", "Error");
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Evitar que el carácter se inserte en el TextBox
                MessageBox.Show("Carácter incorrecto. Por favor, ingrese solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}