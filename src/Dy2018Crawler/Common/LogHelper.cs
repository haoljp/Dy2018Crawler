﻿using NLog;
using System;

namespace Dy2018Crawler
{
    public static class LogHelper
    {
        private static Logger Logger = LogManager.GetCurrentClassLogger();
        

        public static void Info(string message)
        {
            Logger.Info(message);
        }

        public static void Error(string message,Exception ex,object oj =null)
        {
            Logger.Error(message, ex, oj);
        }
       
    }
}
