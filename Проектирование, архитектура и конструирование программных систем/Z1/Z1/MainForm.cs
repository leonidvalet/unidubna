using System;
using System.Windows.Forms;
using Z1;

namespace Z1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadSettings();
            CreateUIElements();
            AppSettings.Instance.SettingChanged += OnSettingChanged;
        }

        private void LoadSettings()
        {
            var settings = AppSettings.Instance;
            UpdateFormTitle(settings.GetSetting("Theme"), settings.GetSetting("Language"));
        }

        private void CreateUIElements()
        {
            UIElementFactory buttonFactory = new ButtonFactory();
            UIElementFactory textBoxFactory = new TextBoxFactory();

            var button = buttonFactory.CreateElement("Сменить тему");
            button.Location = new System.Drawing.Point(50, 50);
            this.Controls.Add(button);

            var textBox = textBoxFactory.CreateElement("");
            textBox.Location = new System.Drawing.Point(50, 100);
            this.Controls.Add(textBox);
        }

        private void OnSettingChanged(string key, string value)
        {
            if (key == "Theme")
            {
                var settings = AppSettings.Instance;
                UpdateFormTitle(value, settings.GetSetting("Language"));
            }
        }

        private void UpdateFormTitle(string theme, string language)
        {
            this.Text = $"Настройки: Тема - {theme}, Язык - {language}";
        }
    }
}