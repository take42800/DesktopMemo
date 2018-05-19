using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows;

using Livet;
using Livet.Commands;
using Livet.Messaging;
using Livet.Messaging.IO;
using Livet.EventListeners;
using Livet.Messaging.Windows;

using DesktopMemo.Models;

namespace DesktopMemo.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {


        #region CloseWindow変更通知プロパティ
        private bool _CloseWindow;

        public bool CloseWindow
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


        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainWindowViewModel()
        {
        }


        /// <summary>
        /// 初期化
        /// </summary>
        public void Initialize()
        {
            // 新規メモウィンドウを開く
            using (var vm = new MemoWindowViewModel())
            {
                Messenger.Raise(new TransitionMessage(vm, "NewMemo"));
            }
            // TODO: 設定ファイルに保存したメモを読み込んで、すべて開く

            // TODO: 終了時に存在するメモを設定ファイルに保存する

            // 画面を閉じるとき
            // CloseWindow = true;
        }



    }
}
