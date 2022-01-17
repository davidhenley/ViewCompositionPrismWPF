using Prism.Regions;
using ViewCompositionPrismWPF.Views;

namespace ViewCompositionPrismWPF.ViewModels
{
    public class ShellWindowViewModel
    {
        private readonly IRegionManager regionManager;

        public ShellWindowViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(ViewA));
        } 
    }
}
