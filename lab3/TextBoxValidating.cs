using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace lab3
{
    class TextBoxValidating: TextBox
    {
        string lastText;
        public delegate bool isValidating(string s);
        public isValidating IsValidating=null;
        protected override void OnTextChanged(EventArgs e)
        {
            if (IsValidating != null)
            {
                if (!IsValidating(Text))
                {
                    BackColor = Color.LightPink;
                }
                else
                {
                    BackColor = Color.White;
                    lastText = Text;
                }
            }
        }
        protected override void OnValidating(CancelEventArgs e)
        {
            if (BackColor == Color.LightPink)
                Text = lastText;
        }
    }
    /*class TextBoxMac : TextBoxValidating
    {
        protected override bool IsValidating(string s)
        {
            Regex rgxMac = new Regex(@"([0-9a-fA-F]{2}([:-]|$)){6}$|([0-9a-fA-F]{4}([.]|$)){3}");
            return rgxMac.IsMatch(s);
        }
    }
    class TextBoxIp : TextBoxValidating
    {
        protected override bool IsValidating(string s)
        {
            Regex rgxIp = new Regex(@"(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?(\.|$)){4}");
            return rgxIp.IsMatch(s);
        }
    }*/

}
