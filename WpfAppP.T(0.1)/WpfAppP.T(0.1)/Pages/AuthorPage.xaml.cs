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
    /// Логика взаимодействия для AuthorPage.xaml
    /// </summary>
    public partial class AuthorPage : Page
    {
        Author ctx;

        public AuthorPage()
        {
            InitializeComponent();

            UpdateList();

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lb_view.ItemsSource);
            view.Filter = c => NameFilter(c);
        }
        public void UpdateList()
        {
            lb_view.ItemsSource = null;
            lb_view.ItemsSource = MainWindow.DBEntities.Author.ToList();
        }

        private void b_go_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_surname.Text.Trim()) || string.IsNullOrWhiteSpace(tb_name.Text.Trim()))
            {
                MessageBox.Show("Необходимо заполнить все обязательные поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {

                if (ctx != null)
                {
                    Author author = MainWindow.DBEntities.Author.Attach(ctx);

                    author.Surname = tb_surname.Text.Trim();
                    author.Name = tb_name.Text.Trim();
                    author.Patronymic = tb_patronymic.Text.Trim();
                    author.HeldPost = tb_heldPost.Text.Trim();
                }
                else
                {
                    Author author = new Author()
                    {
                        Surname = tb_surname.Text.Trim(),
                        Name = tb_name.Text.Trim(),
                        Patronymic = tb_patronymic.Text.Trim(),
                        HeldPost = tb_heldPost.Text.Trim(),
                    };
                    MainWindow.DBEntities.Author.Add(author);

                }
                MainWindow.DBEntities.SaveChanges();

                ctx = null;
                tb_surname.Text = null;
                tb_name.Text = null;
                tb_patronymic.Text = null;
                tb_heldPost.Text = null;

                UpdateList();

                MessageBox.Show("Сохраненно успешно!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void b_edit_Click(object sender, RoutedEventArgs e)
        {
            ctx = (sender as Button).DataContext as Author;
            tb_surname.Text = ctx.Surname;
            tb_name.Text = ctx.Name;
            tb_patronymic.Text = ctx.Patronymic;
            tb_heldPost.Text = ctx.HeldPost;
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

        private void tb_search_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(lb_view.ItemsSource).Refresh();
        }
        private bool NameFilter(object c) =>
                   (c as Author).Surname.ToLower().StartsWith(tb_search.Text.Trim().ToLower()) ||
                   (c as Author).Name.ToLower().StartsWith(tb_search.Text.Trim().ToLower()) ||
                   (c as Author).Patronymic.ToLower().StartsWith(tb_search.Text.Trim().ToLower()) ||
                   (c as Author).HeldPost.ToLower().StartsWith(tb_search.Text.Trim().ToLower()) ||
                   string.IsNullOrWhiteSpace(tb_search.Text.Trim());

        private void b_ascending_Click(object sender, RoutedEventArgs e)
        {
            lb_view.Items.SortDescriptions.Clear();
            lb_view.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Surname", System.ComponentModel.ListSortDirection.Ascending));
        }

        private void b_descending_Click(object sender, RoutedEventArgs e)
        {
            lb_view.Items.SortDescriptions.Clear();
            lb_view.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Surname", System.ComponentModel.ListSortDirection.Descending));
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
    }
}
