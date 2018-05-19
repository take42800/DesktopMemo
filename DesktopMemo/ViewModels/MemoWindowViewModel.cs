using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

using Livet;
using Livet.Commands;
using Livet.Messaging;
using Livet.Messaging.IO;
using Livet.EventListeners;
using Livet.Messaging.Windows;

using DesktopMemo.Models;

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
        #endregion


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
