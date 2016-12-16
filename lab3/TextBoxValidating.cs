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
}
