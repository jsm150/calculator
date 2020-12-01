using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace calculator
{
    internal class Calculate
    {
        private double? _lastNum;
        private bool _lblSet;
        private readonly Stack<char> _ope = new Stack<char>();
        private double? _saveNum;
        public bool Init { get; set; }
        public bool Fir { get; set; } = true;

        public string Add(string s, string o, ref Label label)
        {
            Fir = true;
            _lblSet = true;
            var a = "";
            if (!Init)
                a = Result(false, s, ref label);

            _ope.Push(o.First());
            if (_lblSet)
                label.Text = $@"{label.Text.Substring(0, label.Text.Length - 3)} {_ope.Peek()} ";
            else
                label.Text = label.Text.EndsWith("= ") ? label.Text : label.Text + _lastNum + " " + _ope.Peek() + " ";
            return a;
        }

        public string Result(bool b, string s, ref Label label)
        {
            var deci = false;
            var vs = new string[2];
            if (Fir) _lastNum = double.Parse(string.Concat(s.Where(t => t != ',')));

            if (b && !Fir)
                label.Text = $@"{_saveNum} {_ope.Peek()} {_lastNum} =";
            else if (b)
                label.Text += _lastNum + @" = ";

            if (b) Fir = false;

            if (_saveNum != null && _ope.Count != 0 && _lastNum != null)
            {
                var temp = _ope.Peek();
                switch (temp)
                {
                    case '+':
                        _saveNum += _lastNum;
                        break;
                    case '-':
                        _saveNum -= _lastNum;
                        break;
                    case '*':
                        _saveNum *= _lastNum;
                        break;
                    case '/':
                        _saveNum /= _lastNum;
                        break;
                }
            }
            else
            {
                _saveNum = _lastNum;
            }

            Init = true;
            _lblSet = false;

            IsDeci(ref deci, ref vs, _saveNum.ToString());

            var a = string.Concat(vs[0].Reverse().Where(t => t != '-')
                .Select((t, idx) => idx % 3 == 0 && idx != 0 ? $"{t}," : $"{t}").Reverse());
            if (deci)
                a += "." + vs[1];
            if (_saveNum < 0) a = "-" + a;
            return a;
        }

        public void AllClear()
        {
            _saveNum = null;
            _ope.Clear();
            _lastNum = null;
            Fir = true;
            Init = false;
        }

        public void IsDeci(ref bool deci, ref string[] vs, string s)
        {
            if (s.Contains('.'))
            {
                deci = true;
                vs = s.Split('.');
            }
            else
            {
                vs[0] = s;
            }
        }
    }
}