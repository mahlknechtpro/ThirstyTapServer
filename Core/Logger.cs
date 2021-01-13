using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ThirstyTap.Core
{
    class Logger
    {
        public const int INFO = 0;
        public const int WARNING = 4;
        public const int ERROR = 8;

        public static string Write(int code, string log)
        {
            StringBuilder sb = new StringBuilder();
            string m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string filePath = m_exePath + "\\" + "log.txt";

            DateTime now = DateTime.Now;

            switch (code)
            {
                case INFO:
                    log = now + " | INFO: " + log + "\n";
                    break;
                case WARNING:
                    log = now + " | WARNING: " + log + "\n";
                    break;
                case ERROR:
                    log = now + " | ERROR: " + log + "\n";
                    break;
            }

            sb.Append(log);
            Console.WriteLine(log);

            File.AppendAllText(filePath, sb.ToString());
            sb.Clear();

            return log;
        }
    }
}
