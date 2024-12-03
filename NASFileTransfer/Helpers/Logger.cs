using System;
using System.IO;

namespace NASFileTransfer.Helpers
{
    public static class Logger
    {
        private static readonly string LogDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");

        static Logger()
        {
            if (!Directory.Exists(LogDirectory))
            {
                Directory.CreateDirectory(LogDirectory);
            }
        }

        public static void Log(string message)
        {
            string logFile = Path.Combine(LogDirectory, "log.txt");
            File.AppendAllText(logFile, $"{DateTime.Now}: {message}\n");
        }

        public static void LogError(string message)
        {
            string logFile = Path.Combine(LogDirectory, "error_log.txt");
            File.AppendAllText(logFile, $"{DateTime.Now}: ERROR: {message}\n");
        }
    }
}
