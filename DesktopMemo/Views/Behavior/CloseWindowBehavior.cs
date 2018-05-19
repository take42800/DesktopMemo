﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DesktopMemo.Views.Behavior
{
    public class CloseWindowBehavior
    {
        public static bool GetClose(DependencyObject obj)
        {
            return (bool)obj.GetValue(CloseProperty);
        }
        public static void SetClose(DependencyObject obj, bool value)
        {
            obj.SetValue(CloseProperty, value);
        }
        // Using a DependencyProperty as the backing store for Close.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CloseProperty =
            DependencyProperty.RegisterAttached("Close", typeof(bool), typeof(CloseWindowBehavior), new PropertyMetadata(false, OnCloseChanged));

        private static void OnCloseChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var win = d as Window;
            if (win == null)
            {
                // Window以外のコントロールにこの添付ビヘイビアが付けられていた場合は、
                // コントロールの属しているWindowを取得
                win = Window.GetWindow(d);
            }

            if (GetClose(d))
                win.Close();
        }
    }
}
