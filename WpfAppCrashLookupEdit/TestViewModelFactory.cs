using DevExpress.Xpf.Grid.Native;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppCrashLookupEdit
{
    public static class TestViewModelFactory
    {
        public static TestViewModel CreateViewModel()
        { 
            var viewModel = new TestViewModel();
            var rnd = new Random();
            viewModel.Details = new ObservableCollection<TestViewModelDetail>();
            for (int i = 1; i < 10; i++)
            {
                var detail = new TestViewModelDetail
                {
                    Accounts = GenerateAccounts(i)
                };
                detail.Account = detail.Accounts.Skip(rnd.Next(0, 900)).First().Number;
                viewModel.Details.Add(detail);
            }
            return viewModel;
        }

        public static ObservableCollection<Account> GenerateAccounts(int n)
        {
           var list = new List<Account>();
            for (int i = 0; i < 1000; i++)
            {
                var accountNr = n * 1000 + i;
                var account = new Account
                {
                    Number = accountNr.ToString(),
                    Description = "Account name " + accountNr.ToString()
                };
                list.Add(account);
            }
            return new ObservableCollection<Account>(list);
        }
    }
}
