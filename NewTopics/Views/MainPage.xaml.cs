using NewTopics.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewTopics.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.CustomizableLabel, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.CustomizableLabel:
                        MenuPages.Add(id, new NavigationPage(new CustomizableLabelPage()));
                        break;
                    case (int)MenuItemType.CustomizableNavigationBar:
                        MenuPages.Add(id, new NavigationPage(new CustomizableNavigationBarPage()));
                        break;
                    case (int)MenuItemType.ColordPlaceholder:
                        MenuPages.Add(id, new NavigationPage(new ColordPlaceholderPage()));
                        break;
                    case (int)MenuItemType.BottomTab:
                        MenuPages.Add(id, new NavigationPage(new BottomTabbedPage()));
                        break;
                    case (int)MenuItemType.ImageButton:
                        MenuPages.Add(id, new NavigationPage(new ImageButtonPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}