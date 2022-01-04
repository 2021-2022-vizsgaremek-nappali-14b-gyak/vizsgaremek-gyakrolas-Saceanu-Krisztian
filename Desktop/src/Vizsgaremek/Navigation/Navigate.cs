﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Controls;

namespace Vizsgaremek.Navigation
{
    public static class Navigate
    {
        // elároljuk a MainWindow, hogy tudjuk váltani ablakot (pages)
        public static MainWindow mainWindow;

        /// <summary>
        /// Egy új ablakra vált
        /// </summary>
        /// <param name="userControl">Erre az ablakra váltun</param>
        public static void Navigation(UserControl userControl)
        {
            mainWindow.PageContent.Children.Clear();
            mainWindow.PageContent.Children.Add(userControl);


        }

        public static void NavigationToFullScreen(Page userPage)
        {
        
            mainWindow.Content = userPage;
        }
    }
}
