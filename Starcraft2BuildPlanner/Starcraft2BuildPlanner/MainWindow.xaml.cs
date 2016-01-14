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
                node.Add(new Button() { Style = Application.Current.FindResource("TerranButton") as Style, Content = new Image() { Source = Application.Current.FindResource("VespeneGeyserImage") as BitmapImage } });
                node.Add(new Button() { Style = Application.Current.FindResource("TerranButton") as Style, Content = new Image() { Source = Application.Current.FindResource("RefineryImage") as BitmapImage } });
                for (int j = 0; j < 3; j++)
                {
                    node.Add(new Button() { Style = Application.Current.FindResource("TerranButton") as Style, Content = new Image() { Source = Application.Current.FindResource("SCVImage") as BitmapImage } });
                }
                resourceNodes.Add(node);
            }
            for (int i = 0; i < 8; i++)
            {
                List<Button> node = new List<Button>();
                node.Add(new Button() { Style = Application.Current.FindResource("TerranButton") as Style, Content = new Image() { Source = Application.Current.FindResource("MineralImage") as BitmapImage } });
                for (int j = 0; j < 3; j++)
                {
                    node.Add(new Button() { Style = Application.Current.FindResource("TerranButton") as Style, Content = new Image() { Source = Application.Current.FindResource("SCVImage") as BitmapImage } });
                }
                for (int j = 0; j < 2; j++)
                {
                    node.Add(new Button() { Style = Application.Current.FindResource("TerranButton") as Style, Content = new Image() { Source = Application.Current.FindResource("MuleImage") as BitmapImage } });
                }
                resourceNodes.Add(node);
            }
            List<Button> node2 = new List<Button>();
            node2.Add(new Button() { Style = Application.Current.FindResource("TerranButton") as Style, Content = new Image() { Source = Application.Current.FindResource("HighYieldMineralImage") as BitmapImage } });
            resourceNodes.Add(node2);
            ResourceNodes.ItemsSource = resourceNodes;
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }

        private void TimeBar_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            double newPosition = Canvas.GetLeft(TimeBar) + e.HorizontalChange;
            if (newPosition < 0) // Keeps the TimeBar on the page
            {
                newPosition = 0;
            }
            Canvas.SetLeft(TimeBar, newPosition);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            uint currentTime = ((App)Application.Current).CurrentTimeInTicks;
            MessageBox.Show(currentTime.ToString());
        }
    }
}
