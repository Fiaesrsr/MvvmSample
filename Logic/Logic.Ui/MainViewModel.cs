using GalaSoft.MvvmLight;
using System.Threading.Tasks;

namespace Odas.Logic.Ui
{
 
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            if (IsInDesignMode)
            {
                WindowTitle = "MvvmSample (Design)";
                Progress = 50;
            }
            else
            {
                WindowTitle = "MvvmSample";
                Task.Delay(2000).ContinueWith(
                    t =>
                    {
                        while (Progress < 100)
                        {

                        Progress += 5;
                        Task.Delay(500).Wait();
                        }
                    });
            }
        }
        public string WindowTitle { get; private set; }

        public int Progress { get; set; }
    }
}