using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace calculator
{
    class calculate
    {
        public bool Init { get; set; } = false;
        public bool Fir { get; set; } = true;
        bool lblSet = false;
        double? saveNum = null;
        double? lastNum = null;
        Stack<char> ope = new Stack<char>();
        public string Add(string s, string o, ref Label label)
        {
            Fir = true;
            lblSet = true;
            var a = "";
            if (!Init)
                a = Result(false, s, ref label);

            ope.Push(o.First());
            if (lblSet)
                label.Text = label.Text.Substring(0, label.Text.Count() - 3) + $" {ope.Peek()} ";
            else 
                label.Text = (label.Text.EndsWith("= ")) ? label.Text : label.Text + lastNum + " " + ope.Peek().ToString() + " ";
            return a;
        }

        public string Result(bool b, string s, ref Label label)
        {
            bool deci = false; string[] vs = new string[2];
            if (Fir) lastNum = double.Parse(string.Concat(s.Where(t => t != ',')));

            if (b && !Fir)
                label.Text = $"{saveNum} {ope.Peek()} {lastNum} =";
            else if (b)
                label.Text += lastNum + " = ";

            if (b) Fir = false;

            if (saveNum != null && ope.Count() != 0 && lastNum != null)
            {
                char temp = ope.Peek();
                switch (temp)
                {
                    case '+':
                        saveNum += lastNum;
                        break;
                    case '-':
                        saveNum -= lastNum;
                        break;
                    case '*':
                        saveNum *= lastNum;
                        break;
                    case '/':
                        saveNum /= lastNum;
                        break;
                }
            }
            else
                saveNum = lastNum;
            
            Init = true; lblSet = false;
            
            IsDeci(ref deci, ref vs, saveNum.ToString());

            var a = string.Concat(vs[0].Reverse().Where(t => t != '-').Select((t, idx) => (idx % 3 == 0 && idx != 0) ? $"{t}," : $"{t}").Reverse());
            if (deci)
                a += "." + vs[1];
            if (saveNum < 0) a = "-" + a;
            return a;
        }
        public void AllClear()
        {
            saveNum = null; ope.Clear(); lastNum = null; Fir = true; Init = false;
        }

        public void IsDeci(ref bool deci, ref string[] vs, string s)
        {
            if (s.Contains('.'))
            {
                deci = true; vs = s.Split('.');
            }
            else
                vs[0] = s;
        }
    }
}
