using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLibrary.Models
{
    public class SubjectModel
    {
        /// <summary>
        /// It is a unique identity of each subjects.
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// It represents the subject coding for sem/sy/group.
        /// eg (SEM-YY-##-GRP),(GRP####)
        /// example "122-001-IT","IT001"
        /// </summary>
        public string SubjectCode { get; set; }
        /// <summary>
        /// It represents the actual name of the subject.
        /// </summary>
        public string SubjectTitle { get; set; }
        /// <summary>
        /// For datasource display members
        /// </summary>
        public string FullSubject { get { return $"{SubjectCode}-{SubjectTitle}"; } }
        /// <summary>
        /// It represents the list of all teacher can teach this subject.
        /// </summary>
        public List<TeacherModel> Teachers { get; set; } = new List<TeacherModel>();

    }
}
