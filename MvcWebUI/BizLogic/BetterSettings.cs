using System;
using System.Configuration;

namespace MvcWebUI.BizLogic
{
    public enum AppSettingNames
    {
        ServiceBaseUrl
    }

    public static class BetterSettings
    {
        public static string Get(this AppSettingNames settingName)
        {
            string value = Environment.GetEnvironmentVariable(settingName.ToString());
            if (string.IsNullOrWhiteSpace(value))
                value = ConfigurationManager.AppSettings.Get(settingName.ToString());

            return value;
        }
    }
}