using System.Collections.ObjectModel;

namespace WpfAppCrashLookupEdit
{
    public class TestViewModelDetail
    {
        public string Account { get; set; }
        public ObservableCollection<Account> Accounts { get; set; }
    }
}
