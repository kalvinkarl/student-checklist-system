using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLibrary.Models
{
    public class TeacherModel
    {
        /// <summary>
        /// It is a unique identity of each teachers
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// It represents the first name of the teacher
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// It represents the last name of the teacher
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// For displaymember on datasource binding.
        /// </summary>
        public string FullName { get { return $"{FirstName} {LastName}"; } }

        /// <summary>
        /// It represents the subject that this teacher have
        /// </summary>
        public SubjectModel Subject { get; set; }
    }
}
