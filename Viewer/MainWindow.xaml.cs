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
using Common;
using System.Net;
using System.IO;
using Repository.Service;
using Repository.CSV;
using Repository.SQL;
using Repository.Factory;


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
			ClearListBox();
		}

		private void ClearListBox()
		{
			myList.Items.Clear();
		}

		private void Concrete_Click(object sender, RoutedEventArgs e)
		{
			Common.Person[] people = repository.GetPeople();
			foreach (var person in people)
			{
				myList.Items.Add(person);
			}
		}

		private void Abstraction_Click(object sender, RoutedEventArgs e)
		{
			IEnumerable<Common.Person> people = repository.GetPeople();
			foreach (var person in people)
			{
				myList.Items.Add(person);
			}
		}

		private void Service_Click(object sender, RoutedEventArgs e)
		{
	//		Repository.Interface.IPersonRepository  myRepository = new Service();
	//		PopulateList(new Service());
			PopulateList1("Service");

		}
		private void CSV_Click(object sender, RoutedEventArgs e)
		{
//			Repository.Interface.IPersonRepository myRepository = new CSV();
//			PopulateList(new CSV());
			PopulateList1("CSV");
		}

		private void SQL_Click(object sender, RoutedEventArgs e)
		{
	//		Repository.Interface.IPersonRepository myRepository = new SQL();
	//		PopulateList(new SQL());
			PopulateList1("SQL");
		}
		private void PopulateList(Repository.Interface.IPersonRepository myRepository)
		{
			myList.Items.Clear();
			IEnumerable<Repository.Interface.Person> final = myRepository.GetPeople();
			foreach (var j in final)
			{
				myList.Items.Add(j);
			}
			label.Content = myRepository.GetType().ToString();
		}

		private void PopulateList1(string DataType)
		{
			myList.Items.Clear();
			Repository.Interface.IPersonRepository repository = Factory.GetRepositoryByType(DataType);
			IEnumerable<Repository.Interface.Person> final = repository.GetPeople();

			foreach (var j in final)
			{
				myList.Items.Add(j);
			}
			label.Content = DataType;
		}
	}
}
