using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace MethApp
{
    /// <summary>
    /// Logique d'interaction pour Table.xaml
    /// </summary>
    public partial class win_EXP : Window
    {
        public ObservableCollection<Exploitation> exploitations { get; set; }
        int list_quot = 0;
        int save_quot = 0;

        public bool IsClosed { get; private set; }

        public win_EXP()
        {
            exploitations = DataManager.exploitations;
            InitializeComponent();
            this.DataContext = this;
            datag.ItemsSource = exploitations;
        }

        private void Delobj_bt_Click(object sender, RoutedEventArgs e)
        {
            if (datag.SelectedItems.Count == 0)
                return;

            if(MessageBox.Show("Etes-vous sûr de supprimer " + datag.SelectedItems.Count + " exploitation(s) ?", "Attention, suppression définitive !", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                return;

            var selectedItems = datag.SelectedItems;
            if (selectedItems == null)
                return;

            while(selectedItems.Count > 0)
            {
                exploitations.Remove(selectedItems[0] as Exploitation);
                list_quot++;
            }
        }

        private void Newobj_bt_Click(object sender, RoutedEventArgs e)
        {
            exploitations.Add(new Exploitation());
            list_quot++;
        }

        private void Return_bt_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Save()
        {
            save_quot = list_quot;
            DataManager.exploitations = this.exploitations;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            IsClosed = true;
            return;
            if(list_quot == save_quot)
            {
                e.Cancel = false;
            }
            else
            {
                MessageBoxResult r = MessageBox.Show("Voulez-vous sauvegarder avant de quitter ?", "Attention", MessageBoxButton.YesNoCancel, MessageBoxImage.Warning);
                if(r == MessageBoxResult.Yes)
                {
                    Save();
                    e.Cancel = false;
                }else if(r == MessageBoxResult.No)
                {
                    e.Cancel = false;
                }else if(r == MessageBoxResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Savels_bt_Click(object sender, RoutedEventArgs e)
        {
            Save();
        }
    }
}
