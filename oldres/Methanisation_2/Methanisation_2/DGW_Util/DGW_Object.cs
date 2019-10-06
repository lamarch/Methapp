using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methanisation_2
{
    public abstract class DGW_Object : UniqueID
    {
        
        static long def_val_id = 0;
        public readonly string NAME;

        public abstract void SetFromDGWRow(DataGridViewRow row);

        public abstract DataGridViewRow GetDGWRow();

        public DGW_Object(string name)
        {
            NAME = name;
        }

        public virtual string GetDefaultValue(MemberInfo member)
        {
            return string.Format("<VALEUR PAR DEFAUT #{1}>", member.Name, (def_val_id++).ToString("x"));
        }

        public virtual string GetEmptyValue(MemberInfo member)
        {
            return string.Format("<VALEUR NULLE #{1}>", member.Name, (def_val_id++).ToString("x"));
        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = true)]
    public class ShowInDGWAttribute : Attribute
    {
        public readonly string Name;
        public ShowInDGWAttribute(string printName)
        {
            Name = printName;
        }
    }
}
