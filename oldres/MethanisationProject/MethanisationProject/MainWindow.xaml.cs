using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MethanisationProject
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<MyObj> col = new ObservableCollection<MyObj>();

        public MainWindow()
        {
            InitializeComponent();
            col.Add(new MyObj() { Content = "coucou", CB = true });
            col.Add(new MyObj() { Content = "salut", CB = false });
            col.Add(new MyObj() { Content = "bonjour", CB = true });

            this.ClientLB.ItemsSource = col;
        }
    }

    class MyObj
    {
        public string Content { get; set; }
        public bool CB { get; set; }
    }
}
