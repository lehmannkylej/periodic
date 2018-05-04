using System;

using CommonServiceLocator;

using GalaSoft.MvvmLight.Ioc;

using Periodic.Services;
using Periodic.Views;

namespace Periodic.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register(() => new NavigationServiceEx());
            Register<PivotViewModel, PivotPage>();
            Register<OverviewViewModel, OverviewPage>();
            Register<TrendsViewModel, TrendsPage>();
            Register<BuilderViewModel, BuilderPage>();
            Register<SettingsViewModel, SettingsPage>();
        }

        public SettingsViewModel SettingsViewModel => ServiceLocator.Current.GetInstance<SettingsViewModel>();

        public BuilderViewModel BuilderViewModel => ServiceLocator.Current.GetInstance<BuilderViewModel>();

        public TrendsViewModel TrendsViewModel => ServiceLocator.Current.GetInstance<TrendsViewModel>();

        public OverviewViewModel OverviewViewModel => ServiceLocator.Current.GetInstance<OverviewViewModel>();

        public PivotViewModel PivotViewModel => ServiceLocator.Current.GetInstance<PivotViewModel>();

        public NavigationServiceEx NavigationService => ServiceLocator.Current.GetInstance<NavigationServiceEx>();

        public void Register<VM, V>()
            where VM : class
        {
            SimpleIoc.Default.Register<VM>();

            NavigationService.Configure(typeof(VM).FullName, typeof(V));
        }
    }
}
