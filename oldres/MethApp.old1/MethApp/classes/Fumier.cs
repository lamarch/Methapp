namespace MethApp
{
    [System.Serializable]
    public class Fumier
    {

        public float TxCh4;
        public float MSeche;
        public float Poids;
        public string Nom;
        public string Observations;
        public float Valeur;

        public string ShortDesc { get => $"{Nom}"; }
        public string LongDesc { get => ShortDesc + $" (poids : {Poids} ; Matière Séche : {MSeche} ; Taux de CH4 {TxCh4})"; }

        public Fumier() : this("<inconnu>", 0f, 0f, 0f, 0f, "<aucune>") { }
        public Fumier(string nom, float poids, float mSeche, float txCh4, float valeur, string obs)
        {
            this.Nom = nom;
            this.Poids = poids;
            this.MSeche = mSeche;
            this.TxCh4 = txCh4;
            this.Valeur = valeur;
            this.Observations = obs;
        }

        public override string ToString()
        {
            return base.ToString() + " TxCh4:"+TxCh4+" MSeche:"+MSeche+" Poids:"+Poids+" Nom:"+Nom+" Valeur:"+Valeur;
        }

    }
}
