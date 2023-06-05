using CommunityToolkit.Mvvm.ComponentModel;
using DesignFactory.Icons.Local.Models;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignFactory.Icons.Local.ViewModels
{
    public partial class AutoIconViewModel : ObservableBase, IViewLoadable
    {
        [ObservableProperty]
        private List<IconModel> _icons;

        public void OnLoaded(IViewable view)
        {
            Icons = GetIcons();
        }

        private List<IconModel> GetIcons()
        {
            string[] colors = { "#FCB9AA", "#FFDBCC", "#A2E1DD", "#55CBCD" };
            int colorIndex = 0;

            List<IconModel> source = new();

            foreach (IconType icon in Enum.GetValues(typeof(IconType)))
            {
                if (icon == IconType.None)
                {
                    continue;
                }

                

                IconModel item = new();
                item.IconType = icon;
                item.Name = icon.ToString();
                item.Color = colors[colorIndex];

                source.Add(item);


                colorIndex = colorIndex + 1;

                if (colorIndex > 3)
                {
                    colorIndex = 0;
                }
            }

            return source;
        }
    }
}
