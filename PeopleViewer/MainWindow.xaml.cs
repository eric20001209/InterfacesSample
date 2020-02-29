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
using Repository.Factory;

namespace PeopleViewer
{
	/// <summary>
	/// MainWindow.xaml 的交互逻辑
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Clear_Click(object sender, RoutedEventArgs e)
		{
			myList.Items.Clear();
		}

		private void GetData_Click(object sender, RoutedEventArgs e)
		{

			myList.Items.Clear();
			var repository = ReposistoryFactory
		//	.GetRepo(); 
			.GetRepository();
			IEnumerable<Repository.Interface.Person> people = repository.GetPeople();
			foreach (var p in people)
			{
				myList.Items.Add(p);
			}
		}
	}
}
