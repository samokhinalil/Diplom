using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public class FieldValidator
    {
        public readonly string ErrorText = "Поле не может быть пустым!";
        public readonly string IntErrorText = "Введите число!";

        private ErrorProvider errorProvider = new ErrorProvider();

        public void CheckForEmptyField(TextBox tb, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb.Text.Trim()))
            {
                errorProvider.SetError(tb, ErrorText);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tb, string.Empty);
            }
        }

        public void CheckNumberField(TextBox tb, CancelEventArgs e)
        {
            if (!int.TryParse(tb.Text, out int r))
            {
                errorProvider.SetError(tb, IntErrorText);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tb, string.Empty);
            }
        }
    }
}
