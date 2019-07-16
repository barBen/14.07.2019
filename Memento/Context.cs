using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento
{
    public class Context
    {
        TextCareTaker careTake = new TextCareTaker();

        public void Save(RichTextBox richTex)
        {
            careTake.AddMemento(new TextMemento(richTex.Text));
        }

        public void Undo(RichTextBox richText)
        {
            TextMemento tx = careTake.GetPrev();
            if (tx != null && tx.savedText != null)
            {
                richText.Text = tx.savedText;
               // careTake.RemoveMomento(tx);
            }
        }

        public void Redo(RichTextBox richText)
        {
            TextMemento tx = careTake.GetNext();
            if (tx != null && tx.savedText != null)
            {
                richText.Text = tx.savedText;
            }
        }
    }
}
