﻿using ShopNow.Source_Code.GUI.VIEWS.Admin;
using ShopNow.Source_Code.GUI.VIEWS.Login;

namespace ShopNow
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Quản_lí_sản_phẩm ());
        }
    }
}