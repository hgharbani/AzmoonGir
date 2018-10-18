using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AzmoonGir
{
  public  class AppConfigration
    {
        public AppConfigration()
        {
        }

        public static string FileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\" +
                                        Assembly.GetExecutingAssembly().GetName().Name; 
        public static string ReadSeting(string key)
        {
            string result = string.Empty;
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                result = appSettings[key] ?? "";
            }
            catch (ConfigurationErrorsException e)
            {
                result = "error in app Setting Configuration";
            }

            return result;
        }

        public static void AddOrUpdateAppSetting(string key,string value)
        {
            try
            {
                var congifFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var setting = congifFile.AppSettings.Settings;
                if (setting[key] == null)
                {
                    setting.Add(key,value);

                }
                else
                {
                    setting[key].Value = value;
                    congifFile.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection(congifFile.AppSettings.SectionInformation.Name);
                }



            }
            catch (Exception e)
            {
              
            }

        }
    }
}
