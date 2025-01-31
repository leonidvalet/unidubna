namespace Z3
{
    public partial class MainForm : Form
    {
        private readonly ObservableTextBox _textBox = new ObservableTextBox();
        private readonly TextLogger _logger = new TextLogger();
        private readonly CommandManager _commandManager = new CommandManager();

        public MainForm()
        {
            InitializeComponent();
            _textBox.TextChanged += _logger.LogTextChange;
        }

        private void UpdateTextButton_Click(object sender, EventArgs e)
        {
            var newText = TextInput.Text;
            var command = new ChangeTextCommand(_textBox, newText);
            _commandManager.ExecuteCommand(command);
            TextDisplay.Text = _textBox.Text;
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            _commandManager.Undo();
            TextDisplay.Text = _textBox.Text;
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            _commandManager.Redo();
            TextDisplay.Text = _textBox.Text;
        }
    }
}