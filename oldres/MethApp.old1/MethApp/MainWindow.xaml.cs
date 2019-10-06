using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;

namespace MethApp
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private win_EXP _win_EXP = new win_EXP();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Bls_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            dg_bls.ItemsSource = DataManager.bonLivraisons;
        }

        private void Bt_opt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Bt_exp_Click(object sender, RoutedEventArgs e)
        {
            if (_win_EXP != null && !_win_EXP.IsClosed)
                _win_EXP.Activate();
            else
                _win_EXP = new win_EXP();
            _win_EXP.Show();
        }

        private void Bt_chf_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Bt_fmr_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Bt_delbl_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = dg_bls.SelectedItems;
            if (selectedItems != null)
            {
                //On fait ainsi car selectedItems est lié à la liste donc un for ne fonctionnait pas
                while(selectedItems.Count > 0)
                {
                    DataManager.bonLivraisons.Remove(selectedItems[0] as BonLivraison);
                }
            }
        }

        private void Bt_modbl_Click(object sender, RoutedEventArgs e)
        {
            ModifBL win_modifBl = new ModifBL();
            win_modifBl.Show();
        }

        private void Bt_addbl_Click(object sender, RoutedEventArgs e)
        {
            DataManager.bonLivraisons.Add(new BonLivraison());
        }

        private void Bt_mbu_Click(object sender, RoutedEventArgs e)
        {
            DataManager.MakeBackup();
        }

        private void Bt_lbu_Click(object sender, RoutedEventArgs e)
        {
            DataManager.LoadBackup();
        }
    }
}
