using System;
using System.IO;

namespace CeDirScan
{
    /*
     * Created by Cole Lamers 
     * Date: 11/22/2020
     * Version 1.0
     * 
     * Changes: (date, initials, alteration)
    */
    public class DebugLogging
    {
        static string LogFilePath { get; set; }
        static string LogFileName { get; set; }
        static string LogFilePathAndName { get; set; }

        /* Commented out constructor because I'm calling the CreateDebugLogger() instead to initialize it
        public DebugLogging()
        {
            CreateDebugLogger();
        }
        */
    }
}
