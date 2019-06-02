using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Common
{
    /// <summary>
    /// ページのUriやボタンの作成のための列挙型クラス
    /// </summary>
    public enum PageEnum
    {
        //メインウィンドウ
        [Uri("MainWindow.xaml")]
        MainPage,

        //ログイン画面
        [Uri("screen/LoginPage.xaml")]
        LoginPage,

        //設定画面
        [Uri("screen/ConfigMainPage.xaml")]
        ConfigMainPage,

        //登録画面
        [Uri("Screen/RegisterMainPage.xaml")]
        RegisterMain,

        //画面右側のボタンを列挙している画面
        [Uri("Screen/TempPage.xaml")]
        Temp,

        //ログインエラー画面
        [Uri("Screen/ErrorPage.xaml")]
        Error,
    }
}
