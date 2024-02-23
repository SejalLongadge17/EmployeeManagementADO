using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormado
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
           
        }
        public void Control_Leave(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }

        public void Control_Enter(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.Pink;
        }
        public void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ct = (Control)sender;
            if (e.KeyChar == 13)   //ascii value of enter=13
            {
                SendKeys.Send("{TAB}");//navigate the form using enter
            }
            else if (e.KeyChar == 27)
            {
                SendKeys.Send("+{TAB}");//navigate the form using escape
            }
            if (ct.Tag != null && ct.Tag.ToString() == "int")
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b'))
                {
                    e.KeyChar = (char)0;
                }
            }
            else if (ct.Tag != null && ct.Tag.ToString() == "string")
            {
                string validstring = "abcdefghijklmnopqrstuvwxyz \b.@/-";
                if (!validstring.Contains(e.KeyChar.ToString().ToLower()))
                {
                    e.KeyChar = (char)0;
                }
                if (ct.Text.Split(' ').Length > 2 && e.KeyChar == ' ')
                {
                    e.KeyChar = (char)0;
                }
                if (ct.Text.Length > 0 && ct.Text.Substring(ct.Text.Length - 1) == " " &&
                        e.KeyChar == ' ')
                {
                    e.KeyChar = (char)0;   //0mean false and 1 mean true //return as boolean value typecast as char
                }
            }
            else if (ct.Tag != null && ct.Tag.ToString() == "double")
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b' || e.KeyChar == '.'))
                {
                    e.KeyChar = (char)0;
                }
                if (ct.Text.Contains('.') && e.KeyChar == '.')
                {
                    e.KeyChar = (char)0;
                }
                int dotpos = ct.Text.IndexOf('.');
                if (dotpos >= 0 && e.KeyChar != '\b')
                {
                    if (ct.Text.Substring(dotpos).Length > 2)
                    {
                        e.KeyChar = (char)0;
                    }
                }
            }
        }
        public void ClearControls(Control FocusControl, Control.ControlCollection ctrl, bool ClearFocusControl
            = true)
        {
            string FocusControlValue = "";
            if (!ClearFocusControl)
                FocusControlValue = FocusControl.Text;
            {
                foreach (Control item in ctrl)
                {
                    if (item.Tag != null)
                        item.Text = "";
                    if (item.GetType().Name == "ComboBox")
                    {
                        ComboBox cmb = (ComboBox)item;
                        cmb.SelectedIndex = 0;
                    }
                    if (item.GetType().Name == "CheckBox")
                    {
                        CheckBox chck = (CheckBox)item;
                        chck.Checked = false;
                    }
                }
            }
            if (!ClearFocusControl)
                FocusControl.Text = FocusControlValue;

            FocusControl.Focus();
        }

    }
}
