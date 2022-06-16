using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLibrary.Models
{
    public class StudentModel
    {
        /// <summary>
        /// It is a unique identity of each students.
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// It represents the format that school wants for their unique identity.
        /// eg. (YY-####),(####-MMDDYY),(YY-####-EXPIRY)
        /// </summary>
        public string StudentID { get; set; }
        /// <summary>
        /// It represents the first name of the student.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// It represents the middle name of the student.
        /// </summary>
        public string MiddleName { get; set; }
        /// <summary>
        /// It represents the last name of the student.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// For displaymember on datasource binding.
        /// </summary>
        public string Fullname
        {
            get { return $"{FirstName} {MiddleName[0]}. {LastName}"; }
        }
        /// <summary>
        /// It represents the list of enrolled subjects of the student
        /// </summary>
        public List<SubjectModel> Subjects { get; set; } = new List<SubjectModel>();

    }
}
