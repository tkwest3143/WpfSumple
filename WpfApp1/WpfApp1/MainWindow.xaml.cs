﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Common;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private NavigationService _navi;

        //ロードのためのURI
        private Uri _uri = PageEnum.LoginPage.ToRelativeUri();
        public MainWindow()
        {
            InitializeComponent();
            _navi = this.MainFrame.NavigationService;
        }

        //起動時に初期画面としてロードする
        private void MainFrame_Loaded(object sender,RoutedEventArgs e)
        {
            
            _navi.Navigate(_uri);
        }
    }
}
