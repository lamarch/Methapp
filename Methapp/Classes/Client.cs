using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Methapp.Classes
{
    public class Client : INotifyPropertyChanged
    {
        string nom;
        string proprietaire;
        List<Benne> bennes;


        public event PropertyChangedEventHandler PropertyChanged;

        public string Proprietaire
        {
            get => proprietaire;
            set {
                if (proprietaire != value)
                {
                    proprietaire = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string Nom
        {
            get => nom; 
            set {
                if(nom != value)
                {
                    nom = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public List<Benne> Bennes
        {
            get => bennes; 
            set {
                if(bennes != value)
                {
                    bennes = value;
                    NotifyPropertyChanged();
                }
            }
        }

        void NotifyPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(
                this, 
                new PropertyChangedEventArgs(name));
        }

    }

    public class Benne : INotifyPropertyChanged
    {
        int id;
        float tare;


        public float Matiere(float poids_chargée)
        {
            return poids_chargée - Tare;
        }

        public float Tare
        {
            get => tare;
            set {
                if(tare != value)
                {
                    tare = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public int Id
        {
            get => id;
            set {
                if(id != value)
                {
                    id = value;
                    NotifyPropertyChanged();
                }
            }
        }

        void NotifyPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
