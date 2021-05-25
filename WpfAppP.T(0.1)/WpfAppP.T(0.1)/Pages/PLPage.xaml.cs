using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Логика взаимодействия для PLPage.xaml
    /// </summary>
    public partial class PLPage : Page
    {
        ProgrammingLanguage ctxPL;

        public PLPage()
        {
            InitializeComponent();

            UpdateList();

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lb_PL.ItemsSource);
            view.Filter = c => TitleFilter(c);
        }

        public void UpdateList()
        {
            lb_PL.ItemsSource = null;
            lb_PL.ItemsSource = MainWindow.DBEntities.ProgrammingLanguage.ToList();
        }

        private void b_go_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_PL.Text.Trim()))
            {
                MessageBox.Show("Необходимо заполнить все обязательные поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                
                if (ctxPL != null)
                {
                    ProgrammingLanguage programmingLanguage = MainWindow.DBEntities.ProgrammingLanguage.Attach(ctxPL);

                    programmingLanguage.Title = tb_PL.Text.Trim();
                }
                else
                {
                    ProgrammingLanguage pl = new ProgrammingLanguage()
                    {
                        Title = tb_PL.Text.Trim()
                    };
                    MainWindow.DBEntities.ProgrammingLanguage.Add(pl);
                    
                }
                MainWindow.DBEntities.SaveChanges();

                ctxPL = null;
                tb_PL.Text = null;

                UpdateList();

                MessageBox.Show("Сохраненно успешно!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void b_edit_Click(object sender, RoutedEventArgs e)
        {
            ctxPL = (sender as Button).DataContext as ProgrammingLanguage;
            tb_PL.Text = ctxPL.Title;
        }

        private void b_delete_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            if (MessageBox.Show("Вы уверены что хотите безвозратно удалить запись?",
                "Предупреждение об удалении", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                MainWindow.DBEntities.ProgrammingLanguage.Remove(btn.DataContext as ProgrammingLanguage);
                MainWindow.DBEntities.SaveChanges();
                UpdateList();
                MessageBox.Show("Удалено успешно!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void b_descending_Click(object sender, RoutedEventArgs e)
        {
            lb_PL.Items.SortDescriptions.Clear();
            lb_PL.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Title", System.ComponentModel.ListSortDirection.Descending));
        }

        private void b_ascending_Click(object sender, RoutedEventArgs e)
        {
            lb_PL.Items.SortDescriptions.Clear();
            lb_PL.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Title", System.ComponentModel.ListSortDirection.Ascending));
        }

        private void b_descendingID_Click(object sender, RoutedEventArgs e)
        {
            lb_PL.Items.SortDescriptions.Clear();
            lb_PL.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("DI", System.ComponentModel.ListSortDirection.Descending));
        }

        private void b_ascendingID_Click(object sender, RoutedEventArgs e)
        {
            lb_PL.Items.SortDescriptions.Clear();
            lb_PL.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("DI", System.ComponentModel.ListSortDirection.Ascending));
        }

        private void tb_search_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(lb_PL.ItemsSource).Refresh();
        }
        private bool TitleFilter(object c) =>
           (c as ProgrammingLanguage).Title.ToLower().StartsWith(tb_search.Text.Trim().ToLower()) ||
           string.IsNullOrWhiteSpace(tb_search.Text.Trim());
    }
}
