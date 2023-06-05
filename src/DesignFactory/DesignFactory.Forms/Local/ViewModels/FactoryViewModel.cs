using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Prism.Ioc;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignFactory.Forms.Local.ViewModels
{
    public partial class FactoryViewModel : ObservableBase, IViewLoadable
    {
        private readonly IContainerProvider _containerPropvider;
        private readonly IRegionManager _regionManager;

        public FactoryViewModel(IContainerProvider containerProvider, IRegionManager regionManager)
        {
            _containerPropvider = containerProvider;
            _regionManager = regionManager;
        }

        public void OnLoaded(IViewable view)
        {
        }

        [RelayCommand]
        private void AutoClick()
        {
            RegionChange("AutoContent");
        }

        [RelayCommand]
        private void ManualClick()
        {
            RegionChange("ManualContent");
        }

        private void RegionChange(string content)
        {
            IRegion mainRegion = _regionManager.Regions["MainRegion"];
            IViewable view = _containerPropvider.Resolve<IViewable>(content);

            if (!mainRegion.Views.Contains(view))
            {
                mainRegion.Add(view);
            }

            mainRegion.Activate(view);
        }
    }
}
