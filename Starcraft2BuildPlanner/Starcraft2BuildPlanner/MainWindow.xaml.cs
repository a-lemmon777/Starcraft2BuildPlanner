using System;
using System.Windows;
using System.Windows.Input;

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
            pnlMainGrid.MouseDown += PnlMainGrid_MouseDown;
        }

        private void PnlMainGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Hello!");
        }

        private void pnlMainGrid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("You clicked me at " + e.GetPosition(this).ToString());
        }
    }
}
