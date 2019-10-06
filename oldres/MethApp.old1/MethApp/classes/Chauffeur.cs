namespace MethApp
{
    [System.Serializable]
    public class Chauffeur
    {
        public string Nom;
        public string Prenom;
        public string Description;

        public string ShortDesc => $"{Nom} {Prenom}";
        public string LongDesc => ShortDesc + $" (\" {Description} \")";

        public Chauffeur()
        {
            Nom = "<nom non defini>";
            Prenom = "<prenom non defini>";
            Description = "<description non définie>";
        }

        public Chauffeur(string nom, string prenom, string description)
        {
            Nom = nom;
            Prenom = prenom;
            Description = description;
        }


    }
}
