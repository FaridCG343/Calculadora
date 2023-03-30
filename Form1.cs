using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Calculadora
{

    //<a href="https://www.flaticon.com/free-icons/root" title="root icons">Root icons created by Freepik - Flaticon</a>
    //<a href = "https://www.flaticon.es/iconos-gratis/calculadora" title="calculadora iconos">Calculadora iconos creados por Freepik - Flaticon</a>
    public partial class frmcgfCalculadora : Form
    {
        private double res = 0, num1 = 0, decimales = 10;
        private bool operacion = false, secondNumber = false, firstEntry = false, punto = false, igual = false;
        private string lastOperator = "";
        public frmcgfCalculadora()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        #region Diseño
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        
        private void pbcgfCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbcgfMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbcgfMin_MouseHover(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.DimGray;
            }
            else
            {
                Button btn = (Button)sender;
                btn.BackColor = Color.DimGray;
            }
        }

        private void pbcgfMin_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.FromArgb(64,64,64);
            }
            else
            {
                Button btn = (Button)sender;
                btn.BackColor = Color.FromArgb(64, 64, 64);
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void pnlcgfNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        private void btncgfNum_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (igual)
            {
                clear();
            }

            if (!this.secondNumber && firstEntry)
            {
                num1 = 0;
            }
            if (punto)
            {
                num1 +=  (int.Parse(btn.Text)/ decimales);
                num1 = (double)Math.Round((decimal)num1, (int)Math.Log10((double)decimales));
                //MessageBox.Show(num1 + " " + decimales);
                decimales *= 10;
            }
            else
            {
                num1 = (num1 * 10) + int.Parse(btn.Text);
            }
            if (this.operacion)
            {
                this.secondNumber = true;
            }
            lblcgfNum.Text = num1.ToString();
        }

        private void btncgfOperacion_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            this.igual = false;
            if (this.operacion && this.secondNumber)
            {
                if (!calcular())
                {
                    return;
                }
                this.lastOperator = btn.Text;
                lblcgfNum.Text = res.ToString();
                this.secondNumber = false;
                num1 = 0;
                this.operacion = true;
                this.lblcgfOperacion.Text = res.ToString() + btn.Text;
            }
            else
            {
                if (!this.firstEntry)
                {
                    this.firstEntry = true;
                    res = num1;
                }
                this.lblcgfOperacion.Text = this.res.ToString() + btn.Text;
                this.lastOperator = btn.Text;
                this.operacion = true;
                this.punto = false;
                this.decimales = 10;
            }
        }

        public void btncgfIgual_Click(object sender, EventArgs e)
        {
            if (!firstEntry || !this.operacion)
            {
                firstEntry = true;
                res = num1;
                this.lblcgfOperacion.Text = res.ToString() + "=";
                return;
            }
            this.lblcgfOperacion.Text = res.ToString() + lastOperator + num1 + "=";
            if (!calcular())
            {
                return;
            }
            lblcgfNum.Text = res.ToString();
            this.secondNumber = false;
            this.operacion = true;
            this.igual = true;
        }

        private void btncgfOperacionEspecial_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string operacion = "";
            switch (btn.Text)
            {
                case "1/x":
                    if (num1 == 0)
                    {
                        error("No se puede dividir entre 0");
                        return;
                    }
                    operacion = "1/(" + num1 + ")";
                    num1 = 1 / num1;
                    break;
                case "sqrt":
                    if (num1 < 0)
                    {
                        error("No hay raiz de x < 0");
                        return;
                    }
                    operacion = "sqrt(" + num1 + ")";
                    num1 = Math.Sqrt(num1);
                    break;
                case "x^2":
                    operacion = "(" + num1 + "^2)";
                    num1 *= num1;
                    break;
                case "%":
                    
                    num1 = res * (num1 / 100);
                    operacion = num1.ToString();
                    break;
            }
            if (!firstEntry)
            {
                firstEntry = true;
                res = num1;
                this.lblcgfOperacion.Text += operacion;
                lblcgfNum.Text = res.ToString();
                return;
            }
            else
            {
                lblcgfOperacion.Text = res.ToString() + lastOperator + operacion;
                calcular();
            }
            lblcgfNum.Text = res.ToString();
            this.secondNumber = false;
            this.igual = true;
        }

        private bool calcular()
        {
            switch (lastOperator)
            {
                case "/":
                    if (num1 == 0)
                    {
                        error("No se puede dividir entre 0");
                        return false;
                    }
                    res /= num1;
                    break;
                case "x":
                    res *= num1;
                    break;
                case "+":
                    res += num1;
                    break;
                case "-":
                    res -= num1;
                    break;
            }
            punto = false;
            decimales = 10;
            return true;
        }

        private void btncgfClearE_Click(object sender, EventArgs e)
        {
            num1 = 0;
        }

        private void brncgfBorrar_Click(object sender, EventArgs e)
        {
            if (secondNumber || !firstEntry)
            {
                string temp = lblcgfNum.Text.Substring(0, lblcgfNum.Text.Length - 1);
                num1 = (temp == "" || temp == "-") ? 0 : float.Parse(temp);
                if (punto && decimales != 10)
                {
                    decimales /= 10;
                    if (decimales == 10)
                    {
                        punto = false;
                    }
                }
                lblcgfNum.Text = num1.ToString();
            }
        }

        private void btncgfSigno_Click(object sender, EventArgs e)
        {
            if (num1 != 0)
            {
                num1 *= -1;
                lblcgfNum.Text = num1.ToString();
            }
        }

        public void btncgfPunto_Click(object sender, EventArgs e)
        {
            if (!punto)
            {
                punto = true;
            }
        }

        private void btncgfClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            firstEntry = igual = operacion = secondNumber = punto = false;
            num1 =  res = 0;
            lblcgfNum.Text = "0";
            lblcgfOperacion.Text = "";
            decimales = 10;
        }

        private void error(string message)
        {
            clear();
            lblcgfNum.Text = message;
        }
    }
}