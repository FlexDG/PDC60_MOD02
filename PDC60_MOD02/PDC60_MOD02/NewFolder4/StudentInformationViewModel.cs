using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using PDC60_MOD02.NewFolder2;
using Xamarin.Forms;

namespace PDC60_MOD02.NewFolder4
{
   class StudentInformationViewModel:INotifyPropertyChanged
    {
        public StudentInformation StudentInfo {get;set;}
        public Command CommandInformationUpdate { get;set;}

        public int sID { get;set;}

        public string Sname { get; set; }

        public int sYR { get; set; }

        public string sSection { get; set; }

        public int cCode { get; set; }

        public string Course { get; set; }

        public StudentInformationViewModel()
        {
            CommandInformationUpdate = new Command(() =>
            {


                StudentInfo = new StudentInformation
                {

                    StudentID = sID,
                    StudentName = Sname,
                    YearLevel = sYR,
                    Section = sSection,
                    CourseCode = cCode,
                    Course = Course,

                };

                OnProperyChanged(nameof(StudentInfo));


            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnProperyChanged(string propertyName)
        {


            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
