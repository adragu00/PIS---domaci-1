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

namespace domaci_rad_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.AddLeftButton.Click += new RoutedEventHandler(AddLeftButton_Click);
            this.AddRightButton.Click += new RoutedEventHandler(AddRightButton_Click);
        }
        
        void AddLeftButton_Click(object sender, RoutedEventArgs e)
        {
            this.LeftContainer.Children.Add(new Rectangle()
            {
                Width = 40,
                Height = 40,
                Margin = new Thickness(5, 5, 5, 5),
                Fill = Brushes.Salmon
            });
        }

        void AddRightButton_Click(object sender, RoutedEventArgs e)
        {
            this.RightContainer.Children.Add(new Rectangle()
            {
                Width = 370,
                Height = 30,
                Margin = new Thickness(5, 5, 5, 5),
                Fill = Brushes.MediumSpringGreen
            });
        }
    }
}
