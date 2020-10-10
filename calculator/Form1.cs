using System;
using System.Linq;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        Math math = new Math();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    btn_num_Click(btn_num0, e);
                    break;
                case Keys.NumPad1:
                    btn_num_Click(btn_num1, e);
                    break;
                case Keys.NumPad2:
                    btn_num_Click(btn_num2, e);
                    break;
                case Keys.NumPad3:
                    btn_num_Click(btn_num3, e);
                    break;
                case Keys.NumPad4:
                    btn_num_Click(btn_num4, e);
                    break;
                case Keys.NumPad5:
                    btn_num_Click(btn_num5, e);
                    break;
                case Keys.NumPad6:
                    btn_num_Click(btn_num6, e);
                    break;
                case Keys.NumPad7:
                    btn_num_Click(btn_num7, e);
                    break;
                case Keys.NumPad8:
                    btn_num_Click(btn_num8, e);
                    break;
                case Keys.NumPad9:
                    btn_num_Click(btn_num9, e);
                    break;
                case Keys.Back:
                    btn_del_Click(btn_del, e);
                    break;
                case Keys.Add:
                    NumOperator(btn_add, e);
                    break;
                case Keys.Subtract:
                    NumOperator(btn_minor, e);
                    break;
                case Keys.Divide:
                    NumOperator(btn_div, e);
                    break;
                case Keys.Multiply:
                    NumOperator(btn_mul, e);
                    break;
                case Keys.Decimal:
                    btn_num_Click(btn_dot, e);
                    break;
            }
        }
        private void btn_num_Click(object sender, EventArgs e)
        {
            if (!math.Fir)
                btn_clear_Click(sender, e);
            var num = ((Button)sender).Text;
            var cheak = (lbl_text.Text[0] == '-') ? true : false;
            var deci = false; string[] vs = new string[2];
            string temp = string.Concat(lbl_text.Text.Where(t => t != ',' && t != '-'));

            math.IsDeci(ref deci, ref vs, temp);

            if (!(deci && num == "."))
                if (deci)
                    vs[1] += num;
                else if (num != ".")
                    vs[0] += num;
                else
                    deci = true;

            if (math.Init)
            {
                lbl_text.Text = num; math.Init = false; return;
            }
            else if (lbl_text.Text.Count() < 17)
                if (lbl_text.Text == "0" && num != ".")
                        lbl_text.Text = num;
                else
                    lbl_text.Text = string.Concat(vs[0].Reverse().Select((t, idx) => (idx % 3 == 0 && idx != 0) ? $"{t}," : $"{t}").Reverse());
            if (deci)
                lbl_text.Text += "." + vs[1];
            lbl_text.Text = (cheak) ? "-" + lbl_text.Text : lbl_text.Text;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            var deci = false; string[] vs = new string[2];
            var cheak = (lbl_text.Text[0] == '-') ? true : false;

            var temp = string.Concat(lbl_text.Text.Where((t, idx) => t != ',' && t != '-' && idx != lbl_text.Text.Count() - 1));
            math.IsDeci(ref deci, ref vs, temp);

            lbl_text.Text = (vs[0].Count() != 0) ? string.Concat(vs[0].Reverse().Select((t, idx) => (idx % 3 == 0 && idx != 0) ? $"{t}," : $"{t}").Reverse()) : "0";
            if (deci) 
                lbl_text.Text += "." + vs[1];
            lbl_text.Text = (cheak && lbl_text.Text != "0") ? "-" + lbl_text.Text : lbl_text.Text;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lbl_text.Text = "0"; lbl_state.Text = "";
            math.AllClear(); math.Init = false;
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            lbl_text.Text = "0"; math.Init = false;
        }

        private void btn_pm_Click(object sender, EventArgs e)
        {
            if (!math.Init)
                lbl_text.Text = (lbl_text.Text[0] == '-') ? lbl_text.Text.Substring(1) : "-" + lbl_text.Text;
        }

        private void NumOperator(object sender, EventArgs e)
        {
            string o = ((Button)sender).Text;
            var s = math.Add(lbl_text.Text, o, ref lbl_state);
            if (s != "")
                lbl_text.Text = s;
        }

        private void btn_total_Click(object sender, EventArgs e)
        => lbl_text.Text = math.Result(true, lbl_text.Text, ref lbl_state);

    }
}
