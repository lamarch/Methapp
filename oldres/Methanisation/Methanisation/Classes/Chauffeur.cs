using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methanisation
{
    public class Chauffeur
    {
        public string Nom;
        public string Prenom;
        public string Description;

        string ID;

        public string GETID { get => ID; }

        public string ShortDesc { get => $"{Nom} {Prenom}"; }
        public string LongDesc { get => ShortDesc + $" (\" {Description} \")"; }

        public Chauffeur()
        {
            this.Nom = "<nom indéfini>";
            this.Prenom = "<prenom indéfini>";
            this.Description = "<description indéfinie>";
        }

        public Chauffeur(string nom = "nom non defini", string prenom = "prenom non indéfini", string description = "-")
        {
            this.ID = ID_Store.GetID_str(ID_Store.IDtype.CHF);
            this.Nom = nom;
            this.Prenom = prenom;
            this.Description = description;
        }

        public static Chauffeur GetChauffeurFromDGWRow(DataGridViewRow row, out bool err)
        {
            Chauffeur chauffeur = new Chauffeur();
            if(row.Cells[0].Value != null)
            {
                chauffeur.Nom = row.Cells[0].Value.ToString();
            }

            if (row.Cells[1].Value != null)
            {
                chauffeur.Prenom = row.Cells[1].Value.ToString();
            }

            if (row.Cells[2].Value != null)
            {
                chauffeur.Description = row.Cells[2].Value.ToString();
            }

            err = false;
            return chauffeur;
        }

    }
}
