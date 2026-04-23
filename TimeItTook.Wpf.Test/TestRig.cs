using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions;
using FlaUI.UIA3;

// Turning off XUnit parallel test runs for this project since this is not
// possible with FlaUI automation competing for input controls
[assembly: Xunit.CollectionBehavior(DisableTestParallelization = true)]
namespace TimeItTook.Wpf.Test
{
    public class TestRig : IDisposable
    {
        internal Application? UIApp { get; set; }
        internal UIA3Automation Uia3 { get; set; }
        internal Window? MainWindow { get; set; }
        internal ConditionFactory UIConditionFactory { get; set; }

        public TestRig(TestRigConfig config)
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

        public bool FindControlByName(string propName, out AutomationElement? control)
        {
            control = MainWindow?
                .FindFirstDescendant(cf => cf.ByAutomationId(propName));
            return control != null;
        }

        public Window[] GetAllTopLevelWindows() => UIApp!.GetAllTopLevelWindows(Uia3);

        public void Dispose()
        {
            foreach(var window in GetAllTopLevelWindows())
            {
                window.Close();
            }
            UIApp?.Close();
            UIApp?.Dispose();
            Uia3.Dispose();
        }
    }
}
