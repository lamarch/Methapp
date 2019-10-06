using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using Microsoft.Win32;

namespace MethApp
{
    static class DataManager
    {
        public static ObservableCollection<Exploitation> exploitations = new ObservableCollection<Exploitation>();
        public static ObservableCollection<Fumier> fumiers = new ObservableCollection<Fumier>();
        public static ObservableCollection<Chauffeur> chauffeurs = new ObservableCollection<Chauffeur>();
        public static ObservableCollection<BonLivraison> bonLivraisons = new ObservableCollection<BonLivraison>();
        public static Settings settings = new Settings();

        private static Serialisateur<ObservableCollection<Exploitation>> ser_exp = 
            new Serialisateur<ObservableCollection<Exploitation>>("exploitations.mdata", "data");
        private static Serialisateur<ObservableCollection<Fumier>> ser_fmr = 
            new Serialisateur<ObservableCollection<Fumier>>("fumiers.mdata", "data");
        private static Serialisateur<ObservableCollection<Chauffeur>> ser_chf =
            new Serialisateur<ObservableCollection<Chauffeur>>("chauffeurs.mdata", "data");
        private static Serialisateur<ObservableCollection<BonLivraison>> ser_bls =
            new Serialisateur<ObservableCollection<BonLivraison>>("bon_livraisons.mdata", "data");
        private static Serialisateur<Settings> ser_set =
            new Serialisateur<Settings>(".settings", "data");

        public static async Task SaveData()
        {
            List<Task<bool>> tasks = new List<Task<bool>>();
            tasks.Add(Task.Run(() => ser_exp.Save(exploitations)));
            tasks.Add(Task.Run(() => ser_fmr.Save(fumiers)));
            tasks.Add(Task.Run(() => ser_chf.Save(chauffeurs)));
            tasks.Add(Task.Run(() => ser_bls.Save(bonLivraisons)));
            tasks.Add(Task.Run(() => ser_set.Save(settings)));
            List<bool> res = new List<bool>(await Task.WhenAll(tasks));

            if (!res[0])
            {
                MessageBox.Show("Une erreur est survenue  lors de la sauvegarde des données (exploitations) : " + ser_exp.GetException(), "Erreur !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (!res[1])
            {
                MessageBox.Show("Une erreur est survenue  lors de la sauvegarde des données (fumiers) : " + 
                    ser_fmr.GetException(), "Erreur !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (!res[2])
            {
                MessageBox.Show("Une erreur est survenue lors de la sauvegarde des données (chauffeurs) : " + ser_chf.GetException(), "Erreur !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (!res[3])
            {
                MessageBox.Show("Une erreur est survenue lors de la sauvegarde des données (bon de livraisons) : " +
                    ser_bls.GetException(), "Erreur !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (!res[4])
            {
                MessageBox.Show("Une erreur est survenue lors de la sauvegarde des données (paramètres) : " +
                    ser_set.GetException(), "Erreur !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public static void LoadData()
        {
            exploitations = ser_exp.Load(out bool ok1) ?? new ObservableCollection<Exploitation>();
            fumiers = ser_fmr.Load(out bool ok2) ?? new ObservableCollection<Fumier>();
            chauffeurs = ser_chf.Load(out bool ok3) ?? new ObservableCollection<Chauffeur>();
            bonLivraisons = ser_bls.Load(out bool ok4) ?? new ObservableCollection<BonLivraison>();
            settings = ser_set.Load(out bool ok5) ?? new Settings();

            if (!ok1)
            {
                MessageBox.Show("Une erreur est survenue lors du chargement des données (exploitations) : " + ser_exp.GetException(), "Erreur !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (!ok2)
            {
                MessageBox.Show("Une erreur est survenue lors du chargement des données (fumiers) : " + ser_fmr.GetException(), "Erreur !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (!ok3)
            {
                MessageBox.Show("Une erreur est survenue lors du chargement des données (chauffeurs) : " + ser_chf.GetException(), "Erreur !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (!ok4)
            {
                MessageBox.Show("Une erreur est survenue lors du chargement des données (bon de livraisons) : " +
                    ser_bls.GetException(), "Erreur !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (!ok5)
            {
                MessageBox.Show("Une erreur est survenue lors du chargement des données (paramètres) : " +
                    ser_set.GetException(), "Erreur !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public static void MakeBackup()
        {
            BackupData backupData = new BackupData(exploitations, fumiers, chauffeurs, bonLivraisons, settings);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Sauvegarde des données sécurisées";
            sfd.Filter = "Données de sauvegarde|*.mbackup";
            sfd.OverwritePrompt = true;
            sfd.ValidateNames = true;
            sfd.ShowDialog();

            if (sfd.FileName == "")
            {
                MessageBox.Show("Merci de saisir un nom de fichier ! Sauvegarde annulée.");
                return;
            }
            using (FileStream fs = (FileStream)sfd.OpenFile())
            {
                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    bf.Serialize(fs, backupData);
                    fs.Flush();
                }
                catch(Exception e)
                {
                    MessageBox.Show("Une erreur est survenue lors de la sauvegarde des données en mode sécurisé. \n" + e.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }

        public static void LoadBackup()
        {
            BackupData backupData = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chargement des données sécurisées";
            ofd.Filter = "Données de sauvegarde|*.mbackup";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.Multiselect = false;
            ofd.ShowDialog();

            if (ofd.FileName == "")
            {
                MessageBox.Show("Merci de saisir un nom de fichier ! Sauvegarde annulée.");
                return;
            }

            using (FileStream fs = (FileStream)ofd.OpenFile())
            {
                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    backupData = bf.Deserialize(fs) as BackupData;
                    fs.Flush();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Une erreur est survenue lors du chargement des données en mode sécurisé. \n" + e.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            exploitations = backupData.Exploitations ?? new ObservableCollection<Exploitation>();
            fumiers = backupData.Fumiers ?? new ObservableCollection<Fumier>();
            chauffeurs = backupData.Chauffeurs ?? new ObservableCollection<Chauffeur>();
            bonLivraisons = backupData.BonLivraisons ?? new ObservableCollection<BonLivraison>();
            settings = backupData.Settings ?? new Settings();
        }
    }

    [Serializable]
    public class BackupData
    {
        private ObservableCollection<Exploitation> exploitations = new ObservableCollection<Exploitation>();
        private ObservableCollection<Fumier> fumiers = new ObservableCollection<Fumier>();
        private ObservableCollection<Chauffeur> chauffeurs = new ObservableCollection<Chauffeur>();
        private ObservableCollection<BonLivraison> bonLivraisons = new ObservableCollection<BonLivraison>();
        private Settings settings = new Settings();

        public BackupData() { }

        public BackupData(ObservableCollection<Exploitation> exploitations, ObservableCollection<Fumier> fumiers, ObservableCollection<Chauffeur> chauffeurs, ObservableCollection<BonLivraison> bonLivraisons, Settings settings)
        {
            this.exploitations = exploitations;
            this.fumiers = fumiers;
            this.chauffeurs = chauffeurs;
            this.bonLivraisons = bonLivraisons;
            this.settings = settings;
        }

        public ObservableCollection<Exploitation> Exploitations { get => exploitations; set => exploitations = value; }
        public ObservableCollection<Fumier> Fumiers { get => fumiers; set => fumiers = value; }
        public ObservableCollection<Chauffeur> Chauffeurs { get => chauffeurs; set => chauffeurs = value; }
        public ObservableCollection<BonLivraison> BonLivraisons { get => bonLivraisons; set => bonLivraisons = value; }
        public Settings Settings { get => settings; set => settings = value; }
    }

    [Serializable]
    public class Settings
    {
        public bool doBackupOnStart;
        public Settings() { }
    }
}
