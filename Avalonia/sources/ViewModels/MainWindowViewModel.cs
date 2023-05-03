using Avalonia.Input;
using Avalonia.Interactivity;
using ReactiveUI;
using System.Threading.Tasks;

namespace AvaloniaApplication1.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _Folder1 = "";
        private string _Folder2 = "";
        private string _Title = "";
        private string _Author = "";
        private int _Nomer = 1;

        public string Folder1
        {
            get => _Folder1;
            set => this.RaiseAndSetIfChanged(ref _Folder1, value);
        }

        public string Folder2
        {
            get => _Folder2;
            set => this.RaiseAndSetIfChanged(ref _Folder2, value);
        }
        public string Title
        {
            get => _Title;
            set => this.RaiseAndSetIfChanged(ref _Title, value);
        }

        public string Author
        {
            get => _Author;
            set { }
        }
        public int Nomer
        {
            get => _Nomer;
            set { }
        }

    }
}
