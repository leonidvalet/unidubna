using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z3
{
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void Undo();
    }

    public class ChangeTextCommand : Command
    {
        private readonly ObservableTextBox _textBox;
        private readonly string _newText;
        private string _previousText;

        public ChangeTextCommand(ObservableTextBox textBox, string newText)
        {
            _textBox = textBox;
            _newText = newText;
        }

        public override void Execute()
        {
            _previousText = _textBox.Text;
            _textBox.Text = _newText;
        }

        public override void Undo()
        {
            _textBox.Text = _previousText;
        }
    }

    public class CommandManager
    {
        private readonly Stack<Command> _undoStack = new Stack<Command>();
        private readonly Stack<Command> _redoStack = new Stack<Command>();

        public void ExecuteCommand(Command command)
        {
            command.Execute();
            _undoStack.Push(command);
            _redoStack.Clear();
        }

        public void Undo()
        {
            if (_undoStack.Count > 0)
            {
                var command = _undoStack.Pop();
                command.Undo();
                _redoStack.Push(command);
            }
        }

        public void Redo()
        {
            if (_redoStack.Count > 0)
            {
                var command = _redoStack.Pop();
                command.Execute();
                _undoStack.Push(command);
            }
        }
    }
}
