using System;
using System.Collections.Generic;
using System.Text;

namespace NewTopics.Models
{
    public enum MenuItemType
    {
        CustomizableLabel,
        CustomizableNavigationBar,
        ColordPlaceholder,
        BottomTab,
        ImageButton,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
