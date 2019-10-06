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

namespace MethApp
{
    public partial class DGW_Base<T> : Form where T : DGW_Object
    {
        long dgw_change_level = 0;
        long dgw_save_level = 0;
        string displayName;
        List<MemberInfo> members= new List<MemberInfo>();
        List<T> objectsToPrint = new List<T>();
        T default_object = default(T);

        public DGW_Base(T default_object, string _displayName, params T[] _objectsToPrint)
        {
            InitializeComponent();

            //lors de la modification du dgw
            dgw.Rows.CollectionChanged += new CollectionChangeEventHandler(OnCollectionChanged);
            dgw.CellValueChanged += new DataGridViewCellEventHandler(OnCellContentChanged);

            this.displayName = _displayName;
            this.objectsToPrint = new List<T>(_objectsToPrint);
            this.Text = _displayName;
            this.default_object = default_object;

            //nettoyage du DGW
            dgw.Columns.Clear();

            //
            //creation des colonnes :
            //

            //obtention des membres (propriete(publique)) a afficher                                             ceci afin d'obtenir absolument tout
            List<MemberInfo> memberInfos = new List<MemberInfo>(typeof(T).GetProperties(   (BindingFlags)~0).Cast<MemberInfo>());
            //champs (privé)
            memberInfos.AddRange(typeof(T).GetFields((BindingFlags)~0).Cast<MemberInfo>());
            memberInfos.AddRange(typeof(T).Get)

            foreach(MemberInfo memberInfo in memberInfos)
            {
                //si elle ne possede pas l'attribut ShowDGWAttribute on ne l'affiche pas
                if (memberInfo.GetCustomAttribute<ShowInDGWAttribute>() == null)
                    continue;

                members.Add(memberInfo);

                //ajout d'une colonne
                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                //On met le l'header au parametre passe dans l'attribut (printName)
                column.HeaderCell.Value = "e";// memberInfo.GetCustomAttribute<ShowInDGWAttribute>().Name;
                dgw.Columns.Add(column);
            }

            //
            //creation des lignes
            //

            //affichage des objets
            for (int i = 0; i < objectsToPrint.Count; i++)
            {
                //get object to print
                T obj = objectsToPrint[i];

                //add row
                dgw.Rows.Add(new DataGridViewRow());
                //get row
                DataGridViewRow row = dgw.Rows[i];

                //not null
                if (obj == null)
                    continue;

                //print properties
                for (int j = 0; j < members.Count; j++)
                {
                    //evite repetition
                    MemberInfo member = members[j];
                    Type type;
                    object value;
                    
                    //si c'est un champs ou une propriete, c'est ok
                    //sinon erreur
                    if(member.MemberType == MemberTypes.Field)
                    {
                        //cast dans un champs si c'est un champs
                        value = ((FieldInfo)member).GetValue(obj) + " field";
                        type = ((FieldInfo)member).FieldType;

                    }else if(member.MemberType == MemberTypes.Property)
                    {
                        //cast dans une propriete si c'est une propriete
                        value = ((PropertyInfo)member).GetValue(obj) + " prop";
                        type = ((PropertyInfo)member).PropertyType;
                    }
                    else
                    {
                        //erreur
                        throw new InvalidOperationException("Impossible d'obtenir la valeur autre qu'un champs ou une propriete.");
                    }

                    if (value == null)
                    {
                        
                        value = default_object.GetEmptyValue(member);
                    }
                        

                    row.Cells[j].Value = value;
                }
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            dgw.Rows.Add(new DataGridViewRow());
            DataGridViewRow row = dgw.Rows[dgw.Rows.Count - 1];

            for(int i = 0; i < members.Count; i++)
            {
                MemberInfo member = members[i];
                row.Cells[i].Value = default_object.GetDefaultValue(member);
            }
            
        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            if(dgw.SelectedRows.Count < 1)
            {
                Box.ShowInfo("Merci de séléctionner au moins une ligne à supprimer !");
                return;
            }

            foreach(DataGridViewRow row in dgw.SelectedRows)
            {
                dgw.Rows.Remove(row);
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            dgw_save_level = dgw_change_level;

        }
        
        private void OnCollectionChanged(object sender, CollectionChangeEventArgs args) => dgw_change_level++;

        private void OnCellContentChanged(object sender, DataGridViewCellEventArgs e) => dgw_change_level++;

        private void DGW_Base_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(dgw_change_level != dgw_save_level)
            {
                DialogResult res =  MessageBox.Show("Voulez-vous sauvegarder avant de quitter ?", "Sauvegarde", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if(res == DialogResult.Yes)
                {
                    bt_save_Click(sender, e);

                }else if(res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }




}
