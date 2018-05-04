using System;

using Periodic.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Periodic.Views
{
    public sealed partial class TrendsPage : Page
    {
        private TrendsViewModel ViewModel
        {
            get { return DataContext as TrendsViewModel; }
        }

        public TrendsPage()
        {
            InitializeComponent();
        }
    }
}
