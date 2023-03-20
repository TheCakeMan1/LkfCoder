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
        private bool _Checked = true;
        private bool _Checkeds = false;
        private bool _Ca = false;
        private int _Nomer = 1;

        public string Folder1
        {
            get => _Folder1;
            set => this.RaiseAndSetIfChanged(ref _Folder1, value);
        }

        public void cha()
        {
            if (_Ca == false)
            {
                string name = string.Empty;
                System.IO.DriveInfo[] DI = System.IO.DriveInfo.GetDrives();
                foreach (System.IO.DriveInfo di in DI)
                {
                    if (di.DriveType.ToString() == "Removable")
                        name = di.Name;
                }
                _Folder2 = name;
                _Ca = true;
            }
        }

        public string Folder2
        {
            get {
                cha();
                return _Folder2;
            } 
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

        public bool Checks
        {
            get => _Checked;
            set => this.RaiseAndSetIfChanged(ref _Checked, value);
        }

        public bool Checkss
        {
            get => _Checkeds;
            set => this.RaiseAndSetIfChanged(ref _Checkeds, value);
        }

    }
}
