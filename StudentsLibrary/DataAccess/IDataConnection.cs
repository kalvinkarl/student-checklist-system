using StudentsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLibrary.DataAccess
{
    public interface IDataConnection
    {

        StudentModel CreateStudent(StudentModel student);
        TeacherModel CreateTeacher(TeacherModel teacher);
        SectionModel CreateSection(SectionModel section);
        SubjectModel CreateSubject(SubjectModel subject);
        EnrollmentModel CreateEnrollment(EnrollmentModel enrollment);
        List<StudentModel> GetAllStudents();
        List<StudentModel> GetEnrolled();
        List<StudentModel> GetUnenrolled();
        List<TeacherModel> GetAllTeachers();
        List<SectionModel> GetAllSections();
        List<SubjectModel> GetAllSubjects();
        EnrollmentModel GetEnrollmentByStudent(int StudentID);
    }
}
