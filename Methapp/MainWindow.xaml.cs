using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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


    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        public MainWindow ()
        {
            DataContext = this;
            Exploitations = new ObservableCollection<Exploitation>();
            Exploitations.Add( new Exploitation() {
                Nom = "ferme A",
                Bennes = new ObservableCollection<Benne>() { new Benne() { Id = 0001 } },
                Champs = new ObservableCollection<Champ>() { new Champ( "RGMT", 5.14f ) }
            } );

            Exploitations.Add( new Exploitation() {
                Nom = "ferme B",
                Bennes = new ObservableCollection<Benne>() { new Benne() { Id = 2 } },
                Champs = new ObservableCollection<Champ>() { new Champ() }
            } );
            InitializeComponent();

            lv_exploitations.SelectionChanged += ( object sender, SelectionChangedEventArgs e ) => {
                PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( "Selected_expl" ) );
            };
            lv_exploitations.SelectedItem = lv_exploitations.Items[0];

        }

        public Exploitation Selected_expl {
            get => lv_exploitations.SelectedItem as Exploitation;
        }

        public ObservableCollection<Exploitation> Exploitations { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void bt_add_expl_Click ( object sender, RoutedEventArgs e )
        {
            // add new client
            Exploitations.Add( new Exploitation() );
            lv_exploitations.SelectedItem = lv_exploitations.Items[lv_exploitations.Items.Count - 1];
        }

        private void bt_del_expl_Click ( object sender, RoutedEventArgs e )
        {
            if(lv_exploitations.SelectedItem != null ) {
                Exploitations.Remove( (Exploitation)lv_exploitations.SelectedItem );
            }
        }

        private void bt_add_benne_Click ( object sender, RoutedEventArgs e )
        {
            if(Selected_expl != null ) {
                Selected_expl.Bennes.Add( new Benne() );
                lv_bennes.SelectedItem = lv_bennes.Items[lv_bennes.Items.Count - 1];
            }
        }

        private void bt_del_benne_Click ( object sender, RoutedEventArgs e )
        {
            if(Selected_expl != null && lv_bennes.SelectedItem != null ) {
                Selected_expl.Bennes.Remove( (Benne)lv_bennes.SelectedItem );
            }
        }
    }
}
