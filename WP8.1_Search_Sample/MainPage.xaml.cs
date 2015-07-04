using System.Collections.Generic;
using System.Diagnostics;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace WP8._1_Search_Sample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        List<StudentInfo> StudentList = new List<StudentInfo>();
        
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            StudentList.Add(new StudentInfo() { Name = "Janak", Address = "Chitwan", Phone = "23423645"});
            StudentList.Add(new StudentInfo() { Name = "Ek", Address = "Nepal", Phone = "23243423" });
            StudentList.Add(new StudentInfo() { Name = "Baley", Address = "Surkhet", Phone = "21213552" });
            StudentList.Add(new StudentInfo() { Name = "Suman", Address = "Chitwan", Phone = "55756674" });
            StudentList.Add(new StudentInfo() { Name = "Abinas", Address = "Gulmi", Phone = "235454551" });
            StudentList.Add(new StudentInfo() { Name = "Bipin", Address = "Nepal", Phone = "654567745" });
            StudentList.Add(new StudentInfo() { Name = "Nimesh", Address = "Kathmandu", Phone = "32345234" });
            StudentList.Add(new StudentInfo() { Name = "Jayanta", Address = "Seattle", Phone = "553234464" });
            StudentList.Add(new StudentInfo() { Name = "Vikram", Address = "California", Phone = "2235543452" });
            StudentList.Add(new StudentInfo() { Name = "Iswor", Address = "PPAS", Phone = "634345357" });

            StudentListView.DataContext = StudentList;
        }
        private void Searchbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<StudentInfo> filterStudentList = new List<StudentInfo>();
            filterStudentList.Clear();
            foreach(var student in StudentList)
            {
                if(student.Name.ToLower().Contains(Searchbox.Text.ToLower())
                    || student.Address.ToLower().Contains(Searchbox.Text.ToLower())
                    || student.Phone.ToLower().Contains(Searchbox.Text.ToLower()))
                {
                    filterStudentList.Add(student);
                }
            }
            StudentListView.DataContext = filterStudentList;
        }
    }

    public class StudentInfo
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
