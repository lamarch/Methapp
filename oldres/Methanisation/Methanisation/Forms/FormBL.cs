using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methanisation
{
    public partial class FormBL : Form
    {

        public FormBL()
        {
            InitializeComponent();
        }

        //Lors de l'ouverture de la fenetre
        private void FormBL_Load(object sender, EventArgs e)
        {
            //Debug.MsgInfo("-> " + string.Join(" // ", DataCore.Exploitations));
            cbb_expl.DataSource = DataCore.Exploitations;
            cbb_expl.ValueMember = "GETID";
            cbb_expl.DisplayMember = "ShortDesc";

            cbb_chf.DataSource = DataCore.Chauffeurs;
            cbb_chf.ValueMember = "GETID";
            cbb_chf.DisplayMember = "ShortDesc";

            cbb_fmr.DataSource = DataCore.Fumiers;
            cbb_fmr.ValueMember = "GETID";
            cbb_fmr.DisplayMember = "ShortDesc";

            lb_name_id.Text = "#" + Util.ToHex(ID_Store.ID_BL);
            tb_name.Text = "<NOM_defaut_" + Util.GetRandomIDString() + ">";
        }

        //Lorsque l'utilisateur clique sur 'sauvegarder'
        private void Bt_Save_Click(object sender, EventArgs e)
        {
            //On check si les composants ne sont pas vides:
            // (si non)
            if (!(

               !string.IsNullOrEmpty(tb_name.Text) &&
               !string.IsNullOrWhiteSpace(tb_name.Text) &&
               cbb_chf.SelectedItem != null &&
               cbb_expl.SelectedItem != null &&
               cbb_fmr.SelectedItem != null

              ))
            {
                //Tout n'est pas bien rempli, on annule
                Debug.MsgErr("Tout les champs ne sont pas correctement rempli !", "F1x54");
                return;
            }

            //On créé le bon de livraison
            BonLivraison bl = new BonLivraison(tb_name.Text, dtp_lvr.Value, DateTime.Now, (Exploitation)cbb_expl.SelectedItem, (Fumier)cbb_fmr.SelectedItem, (Chauffeur)cbb_chf.SelectedItem);
            //debug
            Debug.MsgInfo(bl.LongDesc);
            //Et on l'ajoute à la liste
            DataCore.AddBonLivraison(bl);


        }
    }
}
