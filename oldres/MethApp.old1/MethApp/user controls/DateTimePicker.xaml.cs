using System;
using System.Collections.Generic;
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

namespace MethApp
{
    /// <summary>
    /// Logique d'interaction pour UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public DateTime GetDateTime => dt_picker.DisplayDate.Add(GetTime());

        public bool IsValidDateTime => VerifyContent();

        public UserControl1()
        {
            InitializeComponent();
        }

        private TimeSpan GetTime()
        {
            if (!VerifyContent())
                return new TimeSpan();
            return new TimeSpan(int.Parse(tb_hrs.Text), int.Parse(tb_min.Text), 0);
        }

        private bool VerifyContent()
        {
            int hours;
            int minutes;

            if(int.TryParse(tb_hrs.Text, out hours))
            {
                if(int.TryParse(tb_min.Text, out minutes))
                {
                    if(hours >= 0 && hours <= 23)
                    {
                        if(minutes >= 0 && minutes <= 59)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
