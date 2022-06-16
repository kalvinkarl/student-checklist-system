using StudentsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsLibrary.DataAccess.TextProcess;

namespace StudentsLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string StudentFile = "Students.csv";
        private const string TeacherFile = "Teachers.csv";
        private const string SectionFile = "Sections.csv";
        private const string SubjectFile = "Subjects.csv";
        private const string EnrolledFile = "Enrolled.csv";

        public StudentModel CreateStudent(StudentModel student)
        {
            //load the text file
            //convert text to list<StudentModel>
            List<StudentModel> students = StudentFile.FullFilePath().LoadFile().ConvertToStudentModel();

            //find the max ID
            int currentID = 1;
            if(students.Count > 0)
            {
                currentID = students.OrderByDescending(x => x.ID).First().ID + 1;
            }

            student.ID = currentID;
            //Add the new record with the new ID (max+1)
            students.Add(student);

            //Convert the students to list<string>
            //Save the list<strings> to the text file
            students.SaveToStudentFile(StudentFile);

            return student;
        }
        public TeacherModel CreateTeacher(TeacherModel teacher)
        {
            int currentID = 1;
            List<TeacherModel> teachers = TeacherFile.FullFilePath().LoadFile().ConvertToTeacherModel();
            if(teachers.Count > 0)
            {
                currentID = teachers.OrderByDescending(x => x.ID).First().ID + 1;
            }
            teacher.ID = currentID;
            teachers.Add(teacher);
            teachers.SaveToTeacherFile(TeacherFile);
            return teacher;
        }
        public SectionModel CreateSection(SectionModel section)
        {
            int currentID = 1;
            List<SectionModel> sections = SectionFile.FullFilePath().LoadFile().ConverToSectionModel();
            if(sections.Count > 0)
            {
                currentID = sections.OrderByDescending(x => x.ID).First().ID + 1;
            }
            section.ID = currentID;
            sections.Add(section);
            sections.SaveToSectionFile(SectionFile);
            return section;
        }
        public SubjectModel CreateSubject(SubjectModel subject)
        {
            int currentID = 1;
            List<SubjectModel> subjects = SubjectFile.FullFilePath().LoadFile().ConverToSubjectModel();
            if (subjects.Count > 0)
            {
                currentID = subjects.OrderByDescending(x => x.ID).First().ID + 1;
            }
            subject.ID = currentID;
            subjects.Add(subject);
            subjects.SaveToSubjectFile(SubjectFile);
            return subject;
        }
        public List<StudentModel> GetAllStudents()
        {
            return StudentFile.FullFilePath().LoadFile().ConvertToStudentModel();
        }
        public List<StudentModel> GetEnrolled()
        {
            List<EnrollmentModel> enrollees = EnrolledFile.FullFilePath().LoadFile().ConvertToEnrollmentModel(StudentFile, SectionFile, SubjectFile);
            List<StudentModel> studentsEnrolled = new List<StudentModel>();
            foreach(EnrollmentModel enrolled in enrollees)
            {
                studentsEnrolled.Add(enrolled.Student);
            }
            return studentsEnrolled;
        }
        public List<StudentModel> GetUnenrolled()
        {
            List<EnrollmentModel> enrollees = EnrolledFile.FullFilePath().LoadFile().ConvertToEnrollmentModel(StudentFile, SectionFile, SubjectFile);
            List<StudentModel> students = StudentFile.FullFilePath().LoadFile().ConvertToStudentModel();
            List<StudentModel> studentsUnenrolled = new List<StudentModel>();
            foreach(StudentModel student in students)
            {
                if(enrollees.Where(e => e.Student.ID == student.ID).ToList().Count == 0)
                {
                    studentsUnenrolled.Add(student);
                }
            }
            return studentsUnenrolled;
        }
        public List<TeacherModel> GetAllTeachers()
        {
            return TeacherFile.FullFilePath().LoadFile().ConvertToTeacherModel();
        }
        public List<SectionModel> GetAllSections()
        {
            return SectionFile.FullFilePath().LoadFile().ConverToSectionModel();
        }
        public List<SubjectModel> GetAllSubjects()
        {
            return SubjectFile.FullFilePath().LoadFile().ConverToSubjectModel();
        }
        public EnrollmentModel CreateEnrollment(EnrollmentModel enrollment)
        {
            int currentID = 1;
            List<EnrollmentModel> enrollees = EnrolledFile.FullFilePath().LoadFile().ConvertToEnrollmentModel(StudentFile,SectionFile,SubjectFile);
            if (enrollees.Count > 0)
            {
                currentID = enrollees.OrderByDescending(x => x.ID).First().ID + 1;
            }
            enrollment.ID = currentID;
            enrollees.Add(enrollment);
            enrollees.SaveToEnrolledFile(EnrolledFile);
            return enrollment;
        }
        public EnrollmentModel GetEnrollmentByStudent(int StudentID)
        {
            List<EnrollmentModel> Enrollees = EnrolledFile.FullFilePath().LoadFile().ConvertToEnrollmentModel(StudentFile, SectionFile, SubjectFile);
            return Enrollees.Where(x => x.Student.ID == StudentID).First();
        }
    }
}
