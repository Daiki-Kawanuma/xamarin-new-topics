using NewTopics.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewTopics.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.CustomizableLabel, Title="Customizable Label" },
                new HomeMenuItem {Id = MenuItemType.CustomizableNavigationBar, Title="Customizable Navigation Bar" },
                new HomeMenuItem {Id = MenuItemType.ColordPlaceholder, Title="Colord Placeholder" },
                new HomeMenuItem {Id = MenuItemType.BottomTab, Title="Bottom Tab" },
                new HomeMenuItem {Id = MenuItemType.ImageButton, Title="Image Button" },
                new HomeMenuItem {Id = MenuItemType.About, Title="About" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}