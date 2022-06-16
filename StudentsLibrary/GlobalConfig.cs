using StudentsLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;



namespace StudentsLibrary
{
    /// <summary>
    /// Enumerates the database connection to:
    /// Sql = SQL Server
    /// Textfile = Text file
    /// All = All listed functions
    /// </summary>
    public enum DatabaseType { All, Sql, Textfile}

    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql || db == DatabaseType.All)
            {
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            if (db == DatabaseType.Textfile || db == DatabaseType.All)
            {
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
        public static string ConString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        //-----------------------------------------DarkMode---------------------------------------------------------------
        public static bool IsDark = false;
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1 = 19;
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;
        public static bool UseImmersiveDarkMode(IntPtr handle, bool enabled)
        {
            if (IsWindows10OrGreater(17763))
            {
                var attribute = DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1;
                if (IsWindows10OrGreater(18985))
                {
                    attribute = DWMWA_USE_IMMERSIVE_DARK_MODE;
                }
                int useImmersiveDarkMode = enabled ? 1 : 0;
                return DwmSetWindowAttribute(handle, (int)attribute, ref useImmersiveDarkMode, sizeof(int)) == 0;
            }
            return false;
        }
        private static bool IsWindows10OrGreater(int build = -1)
        {
            int.TryParse(Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CurrentBuild", null).ToString(), out int CurrentBuild);
            string ProductName = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName", null).ToString();
            return Regex.IsMatch(ProductName, "^" + Regex.Escape("Windows 10*").Replace("\\*", ".*") + "$") && CurrentBuild >= build;
        }
    }
}
