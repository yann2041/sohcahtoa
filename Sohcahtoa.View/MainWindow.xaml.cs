using Sohcahtoa.ViewModel;
using System.Windows;

namespace Sohcahtoa.View
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      DataContext = new SohcahtoaViewModel();
      InitializeComponent();
    }
  }
}
