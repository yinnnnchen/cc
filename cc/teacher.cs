using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace cc
{
    internal class Teacher
    {
        public String TeacherName { get; set; }

        public ObservableCollection<Course> TeachingCourses { get; set; }

        public Teacher(String TeacherName)
        {
            this.TeacherName = TeacherName;
            TeachingCourses = new ObservableCollection<Course>();
        }
        public override string ToString()
        {
            return TeacherName;
        }
    }
}
