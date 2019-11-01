﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Methapp.Classes;

namespace Methapp
{

        
    public partial class MainWindow : Window
    {
        ObservableCollection<Client> Clients;
        public MainWindow()
        {
            Clients = new ObservableCollection<Client>();
            Clients.Add(new Client() { Nom = "Client_test", Proprietaire = "jack de b.", Bennes = new List<Benne>() { new Benne() { Id=125 }, new Benne() { Id = 15 } } });
            Clients.Add(new Client() { Nom = "Client_test", Proprietaire = "jack de b.", Bennes = new List<Benne>() { new Benne() { Id = 125 }, new Benne() { Id = 15 } } });
            InitializeComponent();
            DataContext = this;
            lv_clients.ItemsSource = Clients;
        }
    }
}
