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
    /// Логика взаимодействия для TaskPage.xaml
    /// </summary>
    public partial class TaskPage : Page
    {
        public TaskPage()
        {
            InitializeComponent();

            UpdateList();

            cb_chapter.ItemsSource = MainWindow.DBEntities.Chapter.ToList();
            cb_chapter.SelectedItem = MainWindow.DBEntities.Chapter.FirstOrDefault();
            cb_theme.ItemsSource = MainWindow.DBEntities.Theme.ToList();
            cb_theme.SelectedItem = MainWindow.DBEntities.Theme.FirstOrDefault();

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lb_view.ItemsSource);
            view.Filter = c => NameFilter(c) ;

        }

        public void UpdateList()
        {
            lb_view.ItemsSource = null;
            lb_view.ItemsSource = MainWindow.DBEntities.Task.ToList();
        }

        private void b_edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void b_delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void b_descendingD_Click(object sender, RoutedEventArgs e)
        {
            lb_view.Items.SortDescriptions.Clear();
            lb_view.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Difficulty", System.ComponentModel.ListSortDirection.Descending));
        }

        private void b_ascendingD_Click(object sender, RoutedEventArgs e)
        {
            lb_view.Items.SortDescriptions.Clear();
            lb_view.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Difficulty", System.ComponentModel.ListSortDirection.Ascending));
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

        private void b_descending_Click(object sender, RoutedEventArgs e)
        {
            lb_view.Items.SortDescriptions.Clear();
            lb_view.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Title", System.ComponentModel.ListSortDirection.Descending));
        }

        private void b_ascending_Click(object sender, RoutedEventArgs e)
        {
            lb_view.Items.SortDescriptions.Clear();
            lb_view.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Title", System.ComponentModel.ListSortDirection.Ascending));
        }

        private void cb_chapter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(lb_view.ItemsSource).Refresh();
        }

        private void cb_theme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(lb_view.ItemsSource).Refresh();
        }

        private void tb_search_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(lb_view.ItemsSource).Refresh();
        }

        private void b_add_Click(object sender, RoutedEventArgs e)
        {

        }
        private bool NameFilter(object c) =>
                   (c as Task).ID.ToString().ToLower().StartsWith(tb_search.Text.Trim().ToLower()) ||
                   (c as Task).Title.ToLower().StartsWith(tb_search.Text.Trim().ToLower()) ||
                   string.IsNullOrWhiteSpace(tb_search.Text.Trim());

        private bool ThemeFilter(object c) => (c as Task).Theme == (cb_theme.SelectedItem as Theme)
           || (cb_theme.SelectedItem as Theme).Value == "Все";
    }
}
