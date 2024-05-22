using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaidShirts
{
    internal class Logger
    {
        private string _logPath;
        public Logger()
        {
            _logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");
        }
        public void Action(string action)
        {
            string log = $"[{DateTime.Now:HH:mm dd.MM.yyyy}] - {action}";
            File.AppendAllText(_logPath, log + Environment.NewLine);
        }
    }
}