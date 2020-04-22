using System.Windows;
using Prymachenko.Loader;

namespace Prymachenko
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new OverlayViewModel();
        }
    }
}