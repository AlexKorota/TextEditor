using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public interface IMessageService
    {
        void ShowMessage(string message);
        void ShowExclamation(string excl);
        void ShowError(string err);
    }

    class MessageService : IMessageService
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowExclamation(string excl)
        {
            MessageBox.Show(excl, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void ShowError(string err)
        {
            MessageBox.Show(err, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
