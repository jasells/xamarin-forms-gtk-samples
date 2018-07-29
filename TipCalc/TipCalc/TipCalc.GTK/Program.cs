﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

namespace TipCalc.GTK
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Gtk.Application.Init();
            Forms.Init();
            var app = new App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("TipCalc");
            window.Show();
            Gtk.Application.Run();
        }
    }
}