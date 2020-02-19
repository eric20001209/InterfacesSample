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
using People.Library;

namespace Viewer
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		PersonRepository repository = new PersonRepository();
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Clear_Click(object sender, RoutedEventArgs e)
		{
			myList.Items.Clear();
		}

		private void Concrete_Click(object sender, RoutedEventArgs e)
		{

		}

		private void Abstraction_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
