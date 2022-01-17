using Prism.DryIoc;
using Prism.Ioc;
using Prism.Regions;
using System.Windows;
using ViewCompositionPrismWPF.Views;

namespace ViewCompositionPrismWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell() => Container.Resolve<ShellWindow>();

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
