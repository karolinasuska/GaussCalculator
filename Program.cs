using System;
using System.Runtime.InteropServices;

namespace GaussCalculator
{
    internal static class Program
    {

        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            AllocConsole();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}