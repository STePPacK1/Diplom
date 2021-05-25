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
    /// Логика взаимодействия для SRPage.xaml
    /// </summary>
    public partial class SRPage : Page
    {
        public SRPage()
        {
            InitializeComponent();

            UpdateList();

            cb_PL.ItemsSource = MainWindow.DBEntities.ProgrammingLanguage.ToList();
            cb_PL.SelectedItem = MainWindow.DBEntities.ProgrammingLanguage.FirstOrDefault();

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lb_view.ItemsSource);
            view.Filter = c => NameFilter(c) && PLFilter(c);

        }
        public void UpdateList()
        {
            lb_view.ItemsSource = null;
            lb_view.ItemsSource = MainWindow.DBEntities.SolutionReference.ToList();
        }

        private void cb_PL_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(lb_view.ItemsSource).Refresh();
        }

        private void tb_search_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(lb_view.ItemsSource).Refresh();
        }

        private void b_descending_Click(object sender, RoutedEventArgs e)
        {
            lb_view.Items.SortDescriptions.Clear();
            lb_view.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("TitleID", System.ComponentModel.ListSortDirection.Descending));
        }

        private void b_ascending_Click(object sender, RoutedEventArgs e)
        {
            lb_view.Items.SortDescriptions.Clear();
            lb_view.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("TitleID", System.ComponentModel.ListSortDirection.Ascending));
        }

        private void b_edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void b_delete_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            if (MessageBox.Show("Вы уверены что хотите безвозратно удалить запись?",
                "Предупреждение об удалении", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                MainWindow.DBEntities.Author.Remove(btn.DataContext as Author);
                MainWindow.DBEntities.SaveChanges();
                UpdateList();
                MessageBox.Show("Удалено успешно!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void b_descendingID_Click(object sender, RoutedEventArgs e)
        {
            lb_view.Items.SortDescriptions.Clear();
            lb_view.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("ID", System.ComponentModel.ListSortDirection.Descending));
        }

        private void b_ascendingID_Click(object sender, RoutedEventArgs e)
        {
            lb_view.Items.SortDescriptions.Clear();
            lb_view.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("ID", System.ComponentModel.ListSortDirection.Ascending));
        }

        private void b_add_Click(object sender, RoutedEventArgs e)
        {
        }

        private bool NameFilter(object c) =>
                 (c as SolutionReference).TaskID.ToString().ToLower().StartsWith(tb_search.Text.Trim().ToLower()) ||
                 (c as SolutionReference).Task.Title.ToString().ToLower().StartsWith(tb_search.Text.Trim().ToLower()) ||
                 string.IsNullOrWhiteSpace(tb_search.Text.Trim());
        private bool PLFilter(object c) => (c as SolutionReference).ProgrammingLanguage == (cb_PL.SelectedItem as ProgrammingLanguage)
                || (cb_PL.SelectedItem as ProgrammingLanguage).Title == "Все";
    }
}
