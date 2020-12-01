using System;
using System.Linq;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        private readonly Calculate _math = new Calculate();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    btn_num0.PerformClick();
                    break;
                case Keys.NumPad1:
                    btn_num1.PerformClick();
                    break;
                case Keys.NumPad2:
                    btn_num2.PerformClick();
                    break;
                case Keys.NumPad3:
                    btn_num3.PerformClick();
                    break;
                case Keys.NumPad4:
                    btn_num4.PerformClick();
                    break;
                case Keys.NumPad5:
                    btn_num5.PerformClick();
                    break;
                case Keys.NumPad6:
                    btn_num6.PerformClick();
                    break;
                case Keys.NumPad7:
                    btn_num7.PerformClick();
                    break;
                case Keys.NumPad8:
                    btn_num8.PerformClick();
                    break;
                case Keys.NumPad9:
                    btn_num9.PerformClick();
                    break;
                case Keys.Back:
                    btn_del.PerformClick();
                    break;
                case Keys.Add:
                    btn_add.PerformClick();
                    break;
                case Keys.Subtract:
                    btn_minor.PerformClick();
                    break;
                case Keys.Divide:
                    btn_div.PerformClick();
                    break;
                case Keys.Multiply:
                    btn_mul.PerformClick();
                    break;
                case Keys.Decimal:
                    btn_dot.PerformClick();
                    break;
                case Keys.C:
                    btn_clear.PerformClick();
                    break;
            }
        }

        private void btn_num_Click(object sender, EventArgs e)
        {
            btn_total.Focus();
            if (!_math.Fir)
                btn_clear_Click(sender, e);
            var num = ((Button) sender).Text;
            var b = lbl_text.Text[0] == '-';
            var deci = false;
            var vs = new string[2];
            var temp = string.Concat(lbl_text.Text.Where(t => t != ',' && t != '-'));

            _math.IsDeci(ref deci, ref vs, temp);

            if (!(deci && num == "."))
            {
                if (deci)
                    vs[1] += num;
                else if (num != ".")
                    vs[0] += num;
                else
                    deci = true;
            }

            if (_math.Init)
            {
                lbl_text.Text = num;
                _math.Init = false;
                return;
            }

            if (lbl_text.Text.Length < 17)
            {
                if (lbl_text.Text == @"0" && num != ".")
                    lbl_text.Text = num;
                else
                    lbl_text.Text = long.Parse(vs[0]).ToString("n0");
            }

            if (deci) lbl_text.Text += @"." + vs[1];
            lbl_text.Text = b ? "-" + lbl_text.Text : lbl_text.Text;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            btn_total.Focus();
            var deci = false;
            var vs = new string[2];
            var b = lbl_text.Text[0] == '-';

            var temp = string.Concat(lbl_text.Text.Where((t, idx) =>
                t != ',' && t != '-' && idx != lbl_text.Text.Length - 1));
            _math.IsDeci(ref deci, ref vs, temp);

            lbl_text.Text = vs[0].Length != 0 ? long.Parse(vs[0]).ToString("n0") : "0";
            if (deci)
                lbl_text.Text += @"." + vs[1];
            lbl_text.Text = b && lbl_text.Text != @"0" ? "-" + lbl_text.Text : lbl_text.Text;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            btn_total.Focus();
            // ReSharper disable once LocalizableElement
            lbl_text.Text = "0";
            lbl_state.Text = "";
            _math.AllClear();
            _math.Init = false;
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            btn_total.Focus();
            // ReSharper disable once LocalizableElement
            lbl_text.Text = "0";
            _math.Init = false;
        }

        private void btn_pm_Click(object sender, EventArgs e)
        {
            if (!_math.Init)
                lbl_text.Text = lbl_text.Text[0] == '-' ? lbl_text.Text.Substring(1) : "-" + lbl_text.Text;
        }

        private void NumOperator(object sender, EventArgs e)
        {
            btn_total.Focus();
            var o = ((Button) sender).Text;
            var s = _math.Add(lbl_text.Text, o, ref lbl_state);
            if (s != "")
                lbl_text.Text = s;
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            lbl_text.Text = _math.Result(true, lbl_text.Text, ref lbl_state);
        }
    }
}