using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLibrary.Models
{
    public class SectionModel
    {
        /// <summary>
        /// It is a unique identity of each seactions.
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// It represents the group of students that we want to call.
        /// eg. "A","B","C" or "Alpha","Beta","Charlie"
        /// </summary>
        public string SectionName { get; set; }
        /// <summary>
        /// It represents the amount of students acceptable in a class.
        /// </summary>
        public int SectionSize { get; set; }
        /// <summary>
        /// For datasource display member
        /// </summary>
        public string FullSection { get { return $"{SectionName}({SectionSize})"; } }
        /// <summary>
        /// It represents the list of students under this section
        /// </summary>
        public List<StudentModel> Students { get; set; } = new List<StudentModel>();
    }
}
