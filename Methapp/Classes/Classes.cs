using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Methapp.Classes
{
    public class Exploitation : INotifyPropertyChanged
    {
        private string nom;
        private ObservableCollection<Benne> bennes;
        private ObservableCollection<Champ> champs;


        public event PropertyChangedEventHandler PropertyChanged;

        public string Nom {
            get => this.nom;
            set {
                if ( this.nom != value ) {
                    this.nom = value;
                    this.NotifyPropertyChanged();
                }
            }
        }
        public ObservableCollection<Benne> Bennes {
            get => this.bennes;
            set {
                if ( this.bennes != value ) {
                    this.bennes = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Champ> Champs { 
            get => this.champs;
            set {
                if(value != champs ) {
                    this.champs = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        private void NotifyPropertyChanged ( [CallerMemberName] string name = "" ) => PropertyChanged?.Invoke(
                this,
                new PropertyChangedEventArgs( name ) );

        public Exploitation ()
        {
            Bennes = new ObservableCollection<Benne>();
            Champs = new ObservableCollection<Champ>();
            Nom = "Nom indéfini";
        }

    }

    public class Champ : INotifyPropertyChanged
    {
        private string nom;
        private float surface;

        public Champ ( string nom, float surface )
        {
            this.nom = nom;
            this.surface = surface;
        }

        public Champ () : this( "Nom indéfini", 0f ) { }

        public float Surface {
            get => this.surface;
            set {
                if ( this.surface != value ) {
                    this.surface = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        public string Nom {
            get => this.nom;
            set {
                if ( value != this.nom ) {
                    this.nom = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        private void NotifyPropertyChanged ( [CallerMemberName] string name = "" ) => PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( name ) );

        public event PropertyChangedEventHandler PropertyChanged;

    }

    public class Benne : INotifyPropertyChanged
    {
        private int id;
        private float tare;


        public float Matiere ( float poids_chargée ) => poids_chargée - Tare;

        public float Tare {
            get => this.tare;
            set {
                if ( this.tare != value ) {
                    this.tare = value;
                    this.NotifyPropertyChanged();
                }
            }
        }
        public int Id {
            get => this.id;
            set {
                if ( this.id != value ) {
                    this.id = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        private void NotifyPropertyChanged ( [CallerMemberName] string name = "" ) => PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( name ) );

        public event PropertyChangedEventHandler PropertyChanged;

        public Benne ()
        {
            this.id = 1;
            this.tare = 0;
        }

    }
}
