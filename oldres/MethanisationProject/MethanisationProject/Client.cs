using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethanisationProject
{
    class Client : INotifyPropertyChanged
    {
        string nom;
        List<Benne> bennes;

        public Client(string nom, List<Benne> bennes)
        {
            this.nom = nom;
            this.bennes = bennes;
        }

        public string Nom { get => nom; set { nom = value; PropChanged("Nom"); } }
        internal List<Benne> Bennes { get => bennes; set { bennes = value; PropChanged("Bennes"); } }

        public event PropertyChangedEventHandler PropertyChanged;

        private void PropChanged(string name)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

    class Benne
    {
        float tare;

        public Benne(float tare)
        {
            this.tare = tare;
        }

        public float Tare { get => tare; set => tare = value; }
    }
}
