using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Interactivity;
using NotSoSimplePaint.ViewModels;

namespace NotSoSimplePaint.Views {
    public partial class MainWindow: Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = new MainWindowViewModel(this);
        }
    }
}