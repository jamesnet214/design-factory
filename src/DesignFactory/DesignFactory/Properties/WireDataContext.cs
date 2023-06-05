using DesignFactory.Forms.Local.ViewModels;
using DesignFactory.Forms.UI.Views;
using DesignFactory.Icons.Local.ViewModels;
using DesignFactory.Icons.UI.Views;
using Jamesnet.Wpf.Global.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignFactory.Properties
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<FactoryWindow, FactoryViewModel>();
            items.Register<AutoContent, AutoIconViewModel>();
        }
    }
}
