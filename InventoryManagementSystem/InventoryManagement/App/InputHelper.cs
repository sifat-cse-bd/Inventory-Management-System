using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.App
{
    public class InputHelper
    {
        public static void AllowDecimalOnly(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null)
                return;

            // Allow control characters (Backspace, Delete, etc.)
            if (char.IsControl(e.KeyChar))
                return;

            // Allow digits
            if (char.IsDigit(e.KeyChar))
                return;

            // Allow only one dot (.)
            if (e.KeyChar == '.')
            {
                string text = textBox.Text;
                int selectionStart = textBox.SelectionStart;
                int selectionLength = textBox.SelectionLength;

                // Build what the text would look like if this key is pressed
                string futureText = text.Substring(0, selectionStart) + e.KeyChar + text.Substring(selectionStart + selectionLength);

                // If dot already exists in future text, block it
                if (futureText.Count(c => c == '.') > 1)
                {
                    e.Handled = true;
                }

                // Dot can't be first character
                if (selectionStart == 0 && text.Length == 0)
                {
                    e.Handled = true;
                }

                return;
            }

            // Block anything else (letters, symbols etc.)
            e.Handled = true;
        }


    }
}
