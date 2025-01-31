using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z1
{
    public abstract class UIElementFactory
    {
        public abstract Control CreateElement(string text);
    }

    public class ButtonFactory : UIElementFactory
    {
        public override Control CreateElement(string text)
        {
            var button = new Button
            {
                Text = text,
                Width = 100,
                Height = 30
            };

            button.Click += (sender, e) =>
            {
                var settings = AppSettings.Instance;
                string currentTheme = settings.GetSetting("Theme");
                string newTheme = currentTheme == "Dark" ? "Light" : "Dark";
                settings.UpdateSetting("Theme", newTheme);
            };

            return button;
        }
    }

    public class TextBoxFactory : UIElementFactory
    {
        public override Control CreateElement(string text)
        {
            var textBox = new TextBox
            {
                Text = text,
                Width = 100,
                Height = 20,
                ReadOnly = true
            };

            var settings = AppSettings.Instance;
            textBox.Text = $"Язык: {settings.GetSetting("Language")}";

            return textBox;
        }
    }
}
