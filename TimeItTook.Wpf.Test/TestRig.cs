using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions;
using FlaUI.UIA3;
using Microsoft.Extensions.Configuration;

namespace TimeItTook.Wpf.Test
{
    internal class TestRig : IDisposable
    {
        internal Application? UIApp { get; set; }
        internal UIA3Automation Uia3 { get; set; }
        internal Window? MainWindow { get; set; }
        internal ConditionFactory UIConditionFactory { get; set; }

        internal TestRig(TestRigConfig config)
        {
            Uia3 = new()
            {
                ConnectionTimeout = config.ConnectionTimeoutSeconds
            };
            var maxRetries = config.MaxRetries;
            while (MainWindow is null && maxRetries > 0)
            {
                maxRetries--;
                UIApp = UIApp ?? Application.Launch(config.AppPath);
                UIApp?.WaitWhileBusy(); //TODO: should I add a timeout for this?  to be tested
                MainWindow = UIApp?.GetMainWindow(Uia3, config.WindowTimeoutSeconds);
            }
            if (MainWindow is null) throw new NullReferenceException("MainWindow init failed");
            UIConditionFactory = new(new UIA3PropertyLibrary());
        }

        public void Dispose()
        {
            MainWindow?.Close();
            UIApp?.Close();
            UIApp?.Dispose();
            Uia3.Dispose();
        }
    }
}
