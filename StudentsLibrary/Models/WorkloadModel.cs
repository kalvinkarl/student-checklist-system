using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLibrary.Models
{
    public class WorkloadModel
    {
        public int ID { get; set; }
        public TeacherModel Teacher { get; set; }
        public List<SubjectModel> Subjects { get; set; }
    }
}
