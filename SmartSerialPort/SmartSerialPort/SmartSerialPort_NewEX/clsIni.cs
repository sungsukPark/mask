using System;

using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace SmartSerialPort_NewEX
{
    class clsIni
    {
       // [DllImport("kernel32")]
       // private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        
       // [DllImport("kernel32")]
       // private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        static string path = "Flash Disk\\Run\\Config.ini";

        //WriteIniFile("BLOG_INFO", "TITLE", "BLANK");
        public void WriteIniFile(string section, string key) {
            //WritePrivateProfileString(section, key, value, path);
            SmartX.SmartFile.WritePrivateProfileString(section, key, "", path);

        }

        // ReadIniFile("USER_INFO", "ID")
        public string ReadIniFile(string section, string key) {
      
            //StringBuilder sb = new StringBuilder(255);
            //GetPrivateProfileString(section, key, "", sb, sb.Capacity, path);

            //return sb.ToString();
         
            
            string outString;
            SmartX.SmartFile.GetPrivateProfileString(section, key, "", out outString, path);
            return outString;
        }

    }
}
