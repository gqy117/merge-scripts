using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace IniFileLibrary
{
    public static class Ini
    {
        public static string Path = Application.StartupPath + "\\" + ConfigFileName;
        public const string ConfigFileName = "config.ini";
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        private const int MaxLength = 255;
        private const string Default_Section = "Config";

        //write key to ini file
        public static void IniWriteValue(string Key, string Value)
        {
            IniWriteValue(Default_Section, Key, Value);
        }
        public static void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, Path);
        }
        public static string IniReadValue(string Key)
        {
            return IniReadValue(Default_Section, Key);
        }
        public static string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(MaxLength);
            int i = GetPrivateProfileString(Section, Key, "", temp, MaxLength, Path);
            return temp.ToString();
        }
    }
}
