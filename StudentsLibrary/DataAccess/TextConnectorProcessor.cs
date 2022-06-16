using StudentsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLibrary.DataAccess.TextProcess
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            if(ConfigurationManager.AppSettings["filePath"] == "default")
            {
                var filePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                Directory.CreateDirectory($"{filePath}\\Datafiles");
                return $"{filePath}\\Datafiles\\{fileName}";
            }
            else
            {
                return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
            }
        }
        //*load the text file
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }
        //*convert text to list<student>
        public static List<StudentModel> ConvertToStudentModel(this List<string> lines)
        {
            List<StudentModel> output = new List<StudentModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                StudentModel student = new StudentModel();
                student.ID = int.Parse(cols[0]);
                student.StudentID = cols[1];
                student.FirstName = cols[2];
                student.MiddleName = cols[3];
                student.LastName = cols[4];
                output.Add(student);
            }
            return output;
        }
        //*Convert the students to list<string>
        public static void SaveToStudentFile(this List<StudentModel> students, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (StudentModel s in students)
            {
                lines.Add($"{s.ID},{s.StudentID},{s.FirstName},{s.MiddleName},{s.LastName}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        //*Save the list<strings> to the text file
        //-----------------------------------------Teacher--------------------------------------------------------------
        public static List<TeacherModel> ConvertToTeacherModel(this List<string> lines)
        {
            List<TeacherModel> output = new List<TeacherModel>();
            foreach(string line in lines)
            {
                string[] cols = line.Split(',');
                TeacherModel teacher = new TeacherModel();
                teacher.ID = int.Parse(cols[0]);
                teacher.FirstName = cols[1];
                teacher.LastName = cols[2];
                output.Add(teacher);
            }
            return output;
        }
        public static void SaveToTeacherFile(this List<TeacherModel> teachers, string fileName)
        {
            List<string> lines = new List<string>();
            foreach(TeacherModel teacher in teachers)
            {
                lines.Add($"{teacher.ID},{teacher.FirstName},{teacher.LastName}");
            }
            File.WriteAllLines(fileName.FullFilePath(),lines);
        }
        //-----------------------------------------Section--------------------------------------------------------------
        public static List<SectionModel> ConverToSectionModel(this List<string> lines)
        {
            List<SectionModel> output = new List<SectionModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                SectionModel section = new SectionModel();
                section.ID = int.Parse(cols[0]);
                section.SectionName = cols[1];
                section.SectionSize = int.Parse(cols[2]);
                output.Add(section);
            }
            return output;
        }
        public static void SaveToSectionFile(this List<SectionModel> sections, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (SectionModel section in sections)
            {
                lines.Add($"{section.ID},{section.SectionName},{section.SectionSize}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        //-----------------------------------------Subject--------------------------------------------------------------
        public static List<SubjectModel> ConverToSubjectModel(this List<string> lines)
        {
            List<SubjectModel> output = new List<SubjectModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                SubjectModel subject = new SubjectModel();
                subject.ID = int.Parse(cols[0]);
                subject.SubjectCode = cols[1];
                subject.SubjectTitle = cols[2];
                output.Add(subject);
            }
            return output;
        }
        public static void SaveToSubjectFile(this List<SubjectModel> subjects, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (SubjectModel subject in subjects)
            {
                lines.Add($"{subject.ID},{subject.SubjectCode},{subject.SubjectTitle}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        //-----------------------------------------Enrollement----------------------------------------------------------
        public static List<EnrollmentModel> ConvertToEnrollmentModel(this List<string> lines,string studentFile,string sectionFile, string subjectFile)
        {
            //Enrollment file format: 1,1,1|2|3|4,1,Datetime.Now()
            List<EnrollmentModel> output = new List<EnrollmentModel>();
            List<StudentModel> students = studentFile.FullFilePath().LoadFile().ConvertToStudentModel();
            List<SubjectModel> subjects = subjectFile.FullFilePath().LoadFile().ConverToSubjectModel();
            List<SectionModel> sections = sectionFile.FullFilePath().LoadFile().ConverToSectionModel();

            foreach(string line in lines)
            {
                string[] cols = line.Split(',');
                EnrollmentModel enrollment = new EnrollmentModel();
                enrollment.ID = int.Parse(cols[0]);
                enrollment.Student = students.Where(s => s.ID == int.Parse(cols[1])).First();
                string[] subjectIDs = cols[2].Split('|');
                foreach (string id in subjectIDs)
                {
                    enrollment.Subjects.Add(subjects.Where(x => x.ID == int.Parse(id)).First());
                }
                enrollment.Section = sections.Where(x => x.ID == int.Parse(cols[3])).First();
                enrollment.Date = DateTime.Parse(cols[4]);
                output.Add(enrollment);
            }
            return output;
        }
        public static void SaveToEnrolledFile(this List<EnrollmentModel> enrollment, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (EnrollmentModel e in enrollment)
            {
                lines.Add($"{e.ID},{e.Student.ID},{ConvertSubjectsToString(e.Subjects)},{e.Section.ID},{DateTime.Now}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        private static string ConvertSubjectsToString(List<SubjectModel> subjects)
        {
            string output = "";
            if(subjects.Count > 0)
            {
                foreach (SubjectModel subject in subjects)
                {
                    output += $"{subject.ID}|";
                }
                output = output.Substring(0, output.Length - 1);
            }
            return output;
        }
    }

}
