using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methanisation_2
{
    static class Box
    {
        public static DialogResult ShowError(string text)
        {
            return MessageBox.Show(text, "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowWarn(string text)
        {
            return MessageBox.Show(text, "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult ShowInfo(string text)
        {
            return MessageBox.Show(text, "Information !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
