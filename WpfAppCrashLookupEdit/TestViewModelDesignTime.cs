using System.Linq;

namespace WpfAppCrashLookupEdit
{
    public class TestViewModelDesignTime : TestViewModel
    {
        public TestViewModelDesignTime()
        {
            var detail = new TestViewModelDetail
            {
                Accounts = TestViewModelFactory.GenerateAccounts(1)
            };
            detail.Account = detail.Accounts.First().Number;
            Details.Add(detail);
            this.Details.Add(detail);
        }
    }
}
