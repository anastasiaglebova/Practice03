using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SchoolApplication.DbEntity;

namespace SchoolApplication.ViewModel
{
    public class AppVM : BaseVM
    {
        /* private Student _student;


         private string _name;
         private string _surname;
         private int _age;

         public string Name
         {
             get => _name;
             set
             {
                 _name = value;
                 OnPropertyChanged(nameof(Name));
             }
         }

         public string Surname
         {
             get => _surname;
             set
             {
                 _surname = value;
                 OnPropertyChanged(nameof(Surname));
             }
         }

         public int Age
         {
             get => _age;
             set
             {
                 _age = value;
                 OnPropertyChanged(nameof(Age));
             }
         }

         public AppVM(Student student)
         {

             Name = student.StudentInfo.Name;
             Surname = student.StudentInfo.Surname;
             Age = (int)student.StudentInfo.Age;
         }

         private void LoadData()
         {
             using (var db = new masterEntities1())
             {
                 var result = db.Student;

             }
         }
        */
        private ObservableCollection<StudentInfo> _studentInfo;

        public ObservableCollection<StudentInfo> StudentInfo
        {
            get => _studentInfo;
            set
            {
                _studentInfo = value;
                OnPropertyChanged(nameof(StudentInfo));
            }
        }

        public AppVM(Student student)
        {
            StudentInfo = new ObservableCollection<StudentInfo>();

            LoadData();
        }

        public void LoadData()
        {
            var result = DbStorage.DB_s.StudentInfo.ToList();

            result.ForEach(elem => StudentInfo?.Add(elem));
        }
    }
}
