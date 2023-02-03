using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppCrashLookupEdit
{
    public class TestViewModel
    {
        public ObservableCollection<TestViewModelDetail> Details { get; set; } = new();
    }
}
