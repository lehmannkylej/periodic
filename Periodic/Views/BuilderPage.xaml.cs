using System;

using Periodic.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Periodic.Views
{
    public sealed partial class BuilderPage : Page
    {
        private BuilderViewModel ViewModel
        {
            get { return DataContext as BuilderViewModel; }
        }

        public BuilderPage()
        {
            InitializeComponent();
        }
    }
}
