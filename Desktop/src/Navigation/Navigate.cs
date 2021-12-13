using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Vizsgaremek.Navigation
{
    public static class Navigate
    {

        public static MainWindow mainwindow;

        public static void Navigation(UserControl usercontrol)
        {
            mainwindow.PageContent.Children.Add(usercontrol);
        }
    }
}
