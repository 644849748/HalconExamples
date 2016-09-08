﻿using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
   internal static class Program
   {
      #region Private Methods

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      private static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new Form1());
      }

      #endregion Private Methods
   }
}