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
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

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
			Person[] people = repository.GetPeople();
			foreach (var person in people)
			{
				myList.Items.Add(person);
			}
		}

		private void Abstraction_Click(object sender, RoutedEventArgs e)
		{
			IEnumerable<Person> people = repository.GetPeople();
			foreach (var person in people)
			{
				myList.Items.Add(person);
			}
		}

		private void Service_Click(object sender, RoutedEventArgs e)
		{
			string url = "https://localhost:44315/api/values";
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
			request.Method = "Get";
			request.ContentType = "text/html;charset=UTF-8";

			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			Stream myResponseStream = response.GetResponseStream();
			StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
			string retString = myStreamReader.ReadToEnd();
			myStreamReader.Close();
			myResponseStream.Close();

			List<Person> personlist = new List<Person>();
			dynamic json = JsonConvert.DeserializeObject(retString);

			personlist = CastToPerson(json, personlist);


			foreach (var j in personlist)
			{
				//personList.Add(j);
				myList.Items.Add($"{j.GivenName}\t{j.FamilyName}");
			}
		}

		public static List<Person> CastToPerson(dynamic myJson, List<Person> result)
		{
			foreach (var i in myJson)
			{
				Person newperson = new Person();
				newperson.FamilyName = i.familyName;
				newperson.GivenName = i.givenName;
				newperson.Id = i.id;
				newperson.Rating = i.rating;
				newperson.startDate = i.startDate;
				result.Add(newperson);
			}

			return result;
		}

		private void CSV_Click(object sender, RoutedEventArgs e)
		{

		}

		private void SQL_Click(object sender, RoutedEventArgs e)
		{

		}
	}

	//public static List<Person> ServiceExtension
	//{ 
		
	//}
}
