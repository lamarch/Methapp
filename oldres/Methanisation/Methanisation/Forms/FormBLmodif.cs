using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methanisation
{
    public partial class FormBLmodif : Form
    {
        BonLivraison bl;

        public FormBLmodif(BonLivraison bl)
        {
            InitializeComponent();
            this.bl = bl;
        }
    }
}
