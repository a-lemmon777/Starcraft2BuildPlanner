using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Starcraft2BuildPlanner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Button> units = new List<Button>();
            units.Add(new Button() { Style = Application.Current.FindResource("TerranButton") as Style });
            Units.ItemsSource = units;

            List<List<Button>> resourceNodes = new List<List<Button>>();
            for (int i = 0; i < 2; i++)
            {
                List<Button> node = new List<Button>();
                node.Add(new Button() { Style = Application.Current.FindResource("TerranButton") as Style, Content = new Image() { Source = Application.Current.FindResource("btn-doodad-vespenegeyser") as BitmapImage } });
                node.Add(new Button() { Style = Application.Current.FindResource("TerranButton") as Style, Content = new Image() { Source = Application.Current.FindResource("btn-building-terran-refinery") as BitmapImage } });
                for (int j = 0; j < 3; j++)
                {
                    node.Add(new Button() { Style = Application.Current.FindResource("TerranButton") as Style, Content = new Image() { Source = Application.Current.FindResource("btn-unit-terran-scv") as BitmapImage } });
                }
                resourceNodes.Add(node);
            }
            ResourceNodes.ItemsSource = resourceNodes;
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }
    }
}
