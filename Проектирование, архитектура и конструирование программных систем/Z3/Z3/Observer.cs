using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z3
{
    public class TextChangedEventArgs : EventArgs
    {
        public string NewText { get; }

        public TextChangedEventArgs(string newText)
        {
            NewText = newText;
        }
    }

    public class ObservableTextBox
    {
        private string _text;
        public event EventHandler<TextChangedEventArgs> TextChanged;

        public string Text
        {
            get => _text;
            set
            {
                if (_text != value)
                {
                    _text = value;
                    OnTextChanged(new TextChangedEventArgs(_text));
                }
            }
        }

        protected virtual void OnTextChanged(TextChangedEventArgs e)
        {
            TextChanged?.Invoke(this, e);
        }
    }

    public class TextLogger
    {
        public void LogTextChange(object sender, TextChangedEventArgs e)
        {
            Console.WriteLine($"Text changed: {e.NewText}");
        }
    }
}
