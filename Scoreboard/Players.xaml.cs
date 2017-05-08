﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Scoreboard
{
    /// <summary>
    /// Interaction logic for Players.xaml
    /// </summary>
    public partial class Players : Window
    {
        public string Player
        {
            get
            {
                ListBoxItem item = (ListBoxItem)_playersList.SelectedItem;
                if (item != null)
                {
                    return item.Content.ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public Players()
        {
            InitializeComponent();
            _playersList.SelectedIndex = 0;
            _playersList.Focus();
        }

        public static string SelectPlayer(Window owner)
        {
            Players players = new Players();
            players.Owner = owner;
            if (players.ShowDialog() == true)
            {
                return players.Player;
            }
            else
            {
                return String.Empty;
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Close();
            }
            else if (e.Key == Key.D1 || e.Key == Key.NumPad1)
            {
                ChoosePlayer(1);
            }
            else if (e.Key == Key.D2 || e.Key == Key.NumPad2)
            {
                ChoosePlayer(2);
            }
            else if (e.Key == Key.D3 || e.Key == Key.NumPad3)
            {
                ChoosePlayer(3);
            }
            else if (e.Key == Key.D4 || e.Key == Key.NumPad4)
            {
                ChoosePlayer(4);
            }
            else if (e.Key == Key.D5 || e.Key == Key.NumPad5)
            {
                ChoosePlayer(5);
            }
            else if (e.Key == Key.D6 || e.Key == Key.NumPad6)
            {
                ChoosePlayer(6);
            }
            else if (e.Key == Key.D7 || e.Key == Key.NumPad7)
            {
                ChoosePlayer(7);
            }
            else if (e.Key == Key.D8 || e.Key == Key.NumPad8)
            {
                ChoosePlayer(8);
            }
            else if (e.Key == Key.D9 || e.Key == Key.NumPad9)
            {
                ChoosePlayer(9);
            }
            else if (e.Key == Key.D0 || e.Key == Key.NumPad0)
            {
                ChoosePlayer(10);
            }
        }       

        private void ChoosePlayer(int value)
        {
            _playersList.SelectedIndex = value;
            DialogResult = true;
        }        

        private void _okButtonClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void ListBoxMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DialogResult = true;
        }
    }
}
