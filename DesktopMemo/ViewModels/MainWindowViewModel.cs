using Livet;
using Livet.Messaging;

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

        #endregion CloseWindow変更通知プロパティ

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