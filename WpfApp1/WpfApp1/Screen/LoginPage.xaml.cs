using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Model;
using WpfApp1.Common;

namespace WpfApp1.Screen
{
    
    /// <summary>
    /// LoginPage.xaml の相互作用ロジック
    /// </summary>
    public partial class LoginPage : Page
    {
        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public LoginPage()
        {
            InitializeComponent();
        }
        #endregion

        #region 画面処理
        /// <summary>
        /// 登録ボタンクリック時の処理です。
        /// </summary>
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageEnum.RegisterMain.ToRelativeUri());
        }

        /// <summary>
        /// ログインボタンクリック時の処理です。
        /// </summary>
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string _username=this.UsernameText.Text;
            string _password = this.PasswordText.Password;
            bool _isLogin = false;

            Login login = new Login();
            login.Username = _username;
            login.Password = _password;

            _isLogin = new LoginCheck().Check(login);

            if (_isLogin)
            {
                Properties.Settings.Default.Username = _username;
                Properties.Settings.Default.Save();
                this.NavigationService.Navigate(PageEnum.Temp.ToRelativeUri());
            }
            else
            {
                this.NavigationService.Navigate(PageEnum.Error.ToRelativeUri());
                
            }
            
        }
        #endregion
    }
}
