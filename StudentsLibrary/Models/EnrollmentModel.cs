using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLibrary.Models
{
    public class EnrollmentModel
    {
        public int ID { get; set; }
        public StudentModel Student { get; set; }
        public List<SubjectModel> Subjects { get; set; } = new List<SubjectModel>();
        public SectionModel Section { get; set; }
        public DateTime Date { get; set; }

    }
}
