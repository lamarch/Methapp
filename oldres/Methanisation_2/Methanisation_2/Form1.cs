using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methanisation_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new DGW_Base<ObjT>(new ObjT("ObjT test"),"ObjT test", new ObjT("test"), new ObjT("nol")).Show();
        }
    }

    public class ObjT : DGW_Object
    {
        [ShowInDGWAttribute("La valeur publique :")]
        public int test_public_int_value = 54;
        [ShowInDGWAttribute("Une valeur statique...")]
        public static int test_public_static_int_value = 54;
        [ShowInDGWAttribute("Un nombre privé.")]
        int test = 0;
        [ShowInDGWAttribute("Une chaine utile ?")]
        public string ro;

        public ObjT(string name) : base(name)
        {

        }

        public override void SetFromDGWRow(DataGridViewRow row)
        {
            throw new NotImplementedException();
        }

        public override DataGridViewRow GetDGWRow()
        {
            throw new NotImplementedException();
        }
    }
}
