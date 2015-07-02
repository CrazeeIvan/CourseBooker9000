using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Booker_9000
{
    class Course
    {
        private int _courseID;      //
        private int _courseDate;
        private string _courseLevel;        
        private string _courseName;
        private string _coursePlaces;
        public int CourseID 
        { 
            get { return _courseID; } 
            set { _courseID = value; } 
        }
        public int CourseDate 
        { 
            get { return _courseDate; } 
            set { _courseDate = value; } 
        }
        public string CourseLevel 
        { 
            get { return _courseLevel; } 
            set { _courseLevel = value; } 
        }
        public string CourseName 
        { 
            get { return _courseName; } 
            set { _courseName = value; } 
        }
        public string CoursePlaces 
        { 
            get { return _coursePlaces; } 
            set { _coursePlaces = value; } 
        }
        public Course(int _id, int _date, string _level, string _name, string _places)
        {
            int courseID = _id;
            int courseDate = _date;
            string courseLevel = _level;
            string courseName = _name;
            string coursePlaces = _places;

        }
        public Course()
        {
        }

    }
}
