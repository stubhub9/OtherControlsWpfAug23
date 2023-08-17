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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    //public partial class MainWindow : Window, IComponentConnector
    public partial class MainWindow : Window
    {
        double pBarIncrement;

        public MainWindow ()
        {
            InitializeComponent ();

            CommandBinding newBinding = new CommandBinding ();
            newBinding.Command = ApplicationCommands.New;
            newBinding.Executed += DoNew_Executed;
            newBinding.CanExecute += DoNew_CanExecute;

            pBarIncrement = 10.0;  // Allows pBar to change direction.

            sp10.Resources.Add ( "background", Brushes.Silver );
            //btn10.Background = (Brush)btn10.TryFindResource ( "background" );
            btn10.Background = (Brush)sp10.Resources ["background"];

            SolidColorBrush aquaBrush = Brushes.Aqua;
            Application app = (Application)Application.Current;
            app.Resources.Add ( "background", aquaBrush );
            btn10.Background = (SolidColorBrush)btn10.TryFindResource ( "background" );

            //  ++++++++++++++  URI  

            Uri uri1 = new Uri ( "/Pointer32.png", UriKind.Relative );
            BitmapImage bi1 = new BitmapImage ( uri1 );
            Image imagePointy = new Image ();
            imagePointy.Height = 32;
            imagePointy.Source = bi1;
            Image imagePointy1 = new Image ();
            imagePointy1.Height = 64;
            imagePointy1.Source = bi1;

            Label label12 = new Label ()
            { Content = "+++++++++   URI    ++++++++++++" };
            Label label13 = new Label ()
            { Content = "Added after the XAML, in the code behind." };
            Col0Panel.Children.Add ( label13 );

            StackPanel stackPanelUri = new StackPanel ()
            {
                Orientation = Orientation.Horizontal,
            };
            Col0Panel.Children.Add ( stackPanelUri );
            stackPanelUri.Children.Add ( imagePointy );
            stackPanelUri.Children.Add ( imagePointy1 );
        }

        private void MenuItemNewGame_Click ( object sender, RoutedEventArgs e )
        {

        }

        public void DoNew_Executed ( object sender, ExecutedRoutedEventArgs e )
        {
            MessageBox.Show ( "New Command Executed", "Command Info" );
        }

        public void DoNew_CanExecute ( object sender, CanExecuteRoutedEventArgs e )
        { e.CanExecute = true; }

        private void Button_Click ( object sender, RoutedEventArgs e )
        {
            pBar.Value += pBarIncrement;

            if ( ( pBar.Value < 10 ) || ( pBar.Value > 90 ) )
            {
                pBarIncrement = -pBarIncrement;
            }

            this.Resources ["gradBrush11"] = Brushes.Teal;
            // StaticResource Xaml assignments won't change, DynamicResource will change.
        }

        private void btn11_Click ( object sender, RoutedEventArgs e )
        {
            btn11.SetResourceReference ( BackgroundProperty, "gradBrush11" );
        }

        private void Button_MouseEnter ( object sender, MouseEventArgs e )
        {
            //Button button = sender as Button;
            Button button = (Button)sender;

            int value;
            if ( int.TryParse ( (string)button.Content, out value ) )
            {
                value++;
                button.Content = value.ToString ();
            }
        }






    }
}
