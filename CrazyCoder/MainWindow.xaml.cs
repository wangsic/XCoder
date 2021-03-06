﻿using System;
using System.Windows;
using System.Windows.Input;
using CrazyCoder.ViewModels;
using CrazyCoder.Views;

namespace CrazyCoder
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel();
        }

        #region 开发工具
        private void Regex_Click(Object sender, RoutedEventArgs e)
        {
            //frame.Navigate(new Uri("Views\\Regex.xaml", UriKind.Relative));
            var frm = new RegexWindow();
            frm.Show();
        }

        private void Ico_Click(Object sender, RoutedEventArgs e)
        {

        }

        private void Security_Click(Object sender, RoutedEventArgs e)
        {

        }

        private void Speech_Click(Object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region 网络通信
        private void Network_Click(Object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region 帮助
        private void CheckUpdate_Click(Object sender, RoutedEventArgs e)
        {

        }

        private void About_Click(Object sender, RoutedEventArgs e)
        {
            //frame.Navigate(new Uri("https://github.com/newlifex"));
            //Process.Start("https://www.newlifex.com");
        }
        #endregion

        #region 窗口控制
        private void Nav_MouseDown(Object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove();
        }

        private void Min_Click(Object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Max_Click(Object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
                WindowState = WindowState.Normal;
            else
                WindowState = WindowState.Maximized;
        }

        private void Close_Click(Object sender, RoutedEventArgs e)
        {
            Close();
        }
        #endregion
    }
}