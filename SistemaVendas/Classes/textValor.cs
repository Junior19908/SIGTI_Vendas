﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas.Classes
{
    internal class textValor : TextBox
    {
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.BackColor = Color.Aquamarine;
            this.SelectAll();
        }
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.BackColor = Color.White;

            if (this.Text == "")
                return;
            try
            {
                double valor = Convert.ToDouble(this.Text.Replace("R$ ", ""));
                this.Text = string.Format("{0:c}", valor);
            }
            catch
            {
                this.Text = "";
                MessageBox.Show("Valor Invalido!");
            }
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Escape)
            {
                this.Text = "";
                e.SuppressKeyPress = true;
            }
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.TextAlign = HorizontalAlignment.Center;
        }
    }
}
