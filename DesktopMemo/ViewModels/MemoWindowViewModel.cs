using Livet;
using System;

namespace DesktopMemo.ViewModels
{
    public class MemoWindowViewModel : ViewModel
    {
        #region CloseWindow変更通知プロパティ

        private string _CloseWindow;

        public string CloseWindow
        {
            get
            { return _CloseWindow; }
            set
            {
                if (_CloseWindow == value)
                    return;
                _CloseWindow = value;
                RaisePropertyChanged(nameof(CloseWindow));
            }
        }

        #endregion CloseWindow変更通知プロパティ

        public MemoWindowViewModel()
        {
            Console.WriteLine("memoVM constructor");
        }

        public void Initialize()
        {
            Console.WriteLine("test memoVM");
        }
    }
}