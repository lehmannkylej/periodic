using System;
using System.Windows.Input;

using Periodic.Services;

using GalaSoft.MvvmLight;

using Windows.ApplicationModel;
using Windows.UI.Xaml;

namespace Periodic.ViewModels
{
    public class OverviewViewModel : ViewModelBase
    {
        public OverviewViewModel()
        {

        }

        private string current = GetDateAndTime.GetDate();
        public string TodayHead {
            get { return "Today - " + current;  }
            set { Set(ref current, value); }
        }

    }
}
