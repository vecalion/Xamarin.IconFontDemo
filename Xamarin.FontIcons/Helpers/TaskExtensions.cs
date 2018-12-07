using System.Diagnostics;
using System.Threading.Tasks;

namespace Xamarin.FontIcons.Helpers
{
    public static class TaskExtensions
    {
        public static void Forget(this Task task)
        {
            task.ContinueWith(
                t =>
                {
                    Debug.WriteLine(t.Exception);
                },
                TaskContinuationOptions.OnlyOnFaulted);
        }
    }
}
