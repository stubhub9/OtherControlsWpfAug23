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
//add:  using System.Windows.Markup;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OtherControlsWpfAug23
{
    /// <summary>
    /// Interaction logic for PageFunctionUserInput15.xaml
    /// </summary>
    //  NOT:?  public partial class PageFunctionUserInput15 : PageFunction<String>
    public partial class PageFunctionUserInput15 : PageFunction<String>, IComponentConnector
    /*!!!!!!!!!!  Had to add; for compiler error suppression re:  missing item
add:  using System.Windows.Markup;
add:  , IComponentConnector  to the class declaration.
    */
    {
        public PageFunctionUserInput15 ()
        {
            InitializeComponent ();
        }

        private void btnAcceptInput_Click ( object sender, RoutedEventArgs e )
        {
            string returnValue = txtbxUserInput.Text;
            OnReturn ( new ReturnEventArgs<string> (returnValue) );
        }
    }
}
