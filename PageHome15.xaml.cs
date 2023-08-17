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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OtherControlsWpfAug23
{
    /// <summary>
    /// Interaction logic for PageHome15.xaml
    /// </summary>
    public partial class PageHome15 : Page, IComponentConnector
    {
        public PageHome15 ()
        {
            InitializeComponent ();
        }


        private void btnShowPicture_Click ( object sender, RoutedEventArgs e )
        {
            NavigationService navigationService = NavigationService.GetNavigationService ( this );
            //NavigationService navigationService = NavigationService.GetNavigationService ( frame18 );
            //string strSelected = ( (ListBoxItem)lbxSelection?.SelectedItem ).Content.ToString () ?? "";
            string strSelected = ( (ListBoxItem)lbxSelection.SelectedItem ).Content.ToString () ?? "";
            if ( strSelected == "Portrait" )
            {
                PagePortrait15 pagePortrait = new PagePortrait15 ();
                navigationService.Navigate ( pagePortrait );
            }
            else if ( strSelected == "Landscape" )
            {
                PageLandscape15 pageLandscape = new PageLandscape15 ();
                navigationService.Navigate ( pageLandscape );
            }
            else if ( strSelected == "This text as new page param")
            {
                PageTextInputParam15 pageTextInputParam15 = new PageTextInputParam15 (strSelected);
                navigationService.Navigate ( pageTextInputParam15 );

            }
            else if ( strSelected == ((string ) lstbxitm4.Content) )
            {
                PageFunctionUserInput15 pageFunction = new PageFunctionUserInput15 ();
                pageFunction.Return +=handlePageFunctionInput;
                this.NavigationService.Navigate (pageFunction);
            }

        }

        private void handlePageFunctionInput (object sender, ReturnEventArgs<string> e)
        {
            string stringReturned = (string)e.Result;
            lstbxitm4.Content = stringReturned ?? "null!";
        }


    }
}
