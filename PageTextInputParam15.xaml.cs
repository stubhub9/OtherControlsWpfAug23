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

namespace OtherControlsWpfAug23
{
    /// <summary>
    /// Interaction logic for PageTextInputParam15.xaml
    /// </summary>
    public partial class PageTextInputParam15 : Page
    {
        public PageTextInputParam15 ()
        {
            InitializeComponent ();
        }

        public PageTextInputParam15 ( string inputString)
        {
            InitializeComponent ();
            txtBlkInputParam15.Text = inputString;
        }


    }
}
