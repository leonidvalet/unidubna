using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1
{
    public class AppSettings
    {
        public event Action<string, string> SettingChanged;

        private AppSettings()
        {
            Settings = new Dictionary<string, string>
        {
            { "Theme", "Dark" },
            { "Language", "English" },
            { "FontSize", "14" }
        };
        }

        private static AppSettings _instance;

        public static AppSettings Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AppSettings();
                }
                return _instance;
            }
        }

        public Dictionary<string, string> Settings { get; private set; }

        public void UpdateSetting(string key, string value)
        {
            if (Settings.ContainsKey(key))
            {
                Settings[key] = value;
            }
            else
            {
                Settings.Add(key, value);
            }

            SettingChanged?.Invoke(key, value);
        }

        public string GetSetting(string key)
        {
            return Settings.ContainsKey(key) ? Settings[key] : null;
        }
    }
}
