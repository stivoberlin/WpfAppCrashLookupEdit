namespace WpfAppCrashLookupEdit
{
    public class Account
    {
        public string Number { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Number + " " + Description;
        }
    }
}
