using System;

using Periodic.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Periodic.Views
{
    public sealed partial class OverviewPage : Page
    {
        private OverviewViewModel ViewModel
        {
            get { return DataContext as OverviewViewModel; }
        }

        public OverviewPage()
        {
            InitializeComponent();
        }
    }
}
