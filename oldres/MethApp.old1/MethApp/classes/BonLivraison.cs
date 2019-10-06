using System;

namespace MethApp
{
    [Serializable]
    public class BonLivraison
    {
        string description;
        string observations;
        string remarques;
        DateTime dateDeLivraison;
        DateTime dateDeCreation;
        Exploitation exploitation;
        Fumier fumier;
        Chauffeur chauffeur;

        public BonLivraison()
        {
            this.description = "<description indéfinie>";
            this.dateDeLivraison = new DateTime();
            this.dateDeCreation = new DateTime();
            this.exploitation = new Exploitation();
            this.fumier = new Fumier();
            this.chauffeur = new Chauffeur();
            this.observations = "<observations indéfinies>";
            this.remarques = "<remarques indéfinies>";
        }
        public BonLivraison(string description, DateTime dateDeLivraison, DateTime dateDeCreation, Exploitation exploitation, Fumier fumier, Chauffeur chauffeur, string observations, string remarques)
        {
            this.description = description;
            this.dateDeLivraison = dateDeLivraison;
            this.dateDeCreation = dateDeCreation;
            this.exploitation = exploitation;
            this.fumier = fumier;
            this.chauffeur = chauffeur;
            this.observations = observations;
            this.remarques = remarques;
        }

        public string Description { get => description; set => description = value; }
        public DateTime DateDeLivraison { get => dateDeLivraison; set => dateDeLivraison = value; }
        public DateTime DateDeCreation { get => dateDeCreation; set => dateDeCreation = value; }
        public Exploitation Exploitation { get => exploitation; set => exploitation = value; }
        public Fumier Fumier { get => fumier; set => fumier = value; }
        public Chauffeur Chauffeur { get => chauffeur; set => chauffeur = value; }
        public string Observations { get => observations; set => observations = value; }
        public string Remarques { get => remarques; set => remarques = value; }
    }
}
