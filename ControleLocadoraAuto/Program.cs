﻿using ControleLocadoraAuto.Entities;
using ControleLocadoraAuto.Services;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace ControleLocadoraAuto
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
