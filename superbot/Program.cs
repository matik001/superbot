﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using superbot.Models;
using superbot.Views;

namespace superbot
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //ExtentionsManager.addExtension(Config.extension, Config.extensionName, Application.ExecutablePath);
            string scriptPath = args.FirstOrDefault();
            if (scriptPath == null)
            {
                Application.Run(new MainForm());
            }
            else
            {
                Macro macro = new Macro(scriptPath);
                macro.run();
            }
        }
    }
}