using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppP.T_0._1_.Pages
{
    /// <summary>
    /// Логика взаимодействия для ThemePage.xaml
    /// </summary>
    public partial class ThemePage : Page
    {
        public ThemePage()
        {
            InitializeComponent();

            tv_theme.ItemsSource = MainWindow.DBEntities.Theme.ToList();
        }
    }
}
