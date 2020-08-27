using ASM_News.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ASM_News.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ObservableCollection<MenuItems> MenuItems;
        ObservableCollection<New> News;
        public MainPage()
        {
            this.InitializeComponent();
            MenuItems = new ObservableCollection<MenuItems>();
            News = new ObservableCollection<New>();
            MenuItems.Add(new MenuItems { IconFile = "/Assets/Icons/Politics.jpg", Category = NewsCategory.Politics });
            MenuItems.Add(new MenuItems { IconFile = "/Assets/Icons/Weather.png", Category = NewsCategory.Weather });
            MenuItems.Add(new MenuItems { IconFile = "/Assets/Icons/Technology.jpg", Category = NewsCategory.Technology });
            MenuItems.Add(new MenuItems { IconFile = "/Assets/Icons/Entertainment.png", Category = NewsCategory.Entertainment });

            NewManager.GetAllNews(News);
            BackButton.Visibility = Visibility.Collapsed;
        }

        private void MenuItemsListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var menuItem = (MenuItems)e.ClickedItem;
            //filter on category
            TitleTextBlock.Text = menuItem.Category.ToString();
            NewManager.GetNewByCategory(News, menuItem.Category);
            BackButton.Visibility = Visibility.Visible;
        }

        private void SearchAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {

        }

        private void SearchAutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            NewManager.GetNewByTile(News, sender.Text);
            TitleTextBlock.Text = sender.Text;
            MenuListViewsItem.SelectedItem = null;
            BackButton.Visibility = Visibility.Visible;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            goBack();
        }

        private void CategoryButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void NewGridView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private void goBack()
        {
            NewManager.GetAllNews(News);
            TitleTextBlock.Text = "Home";
            MenuListViewsItem.SelectedItem = null;
            BackButton.Visibility = Visibility.Collapsed;
        }
    }
}
