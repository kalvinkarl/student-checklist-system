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
        /// <summary>
        /// Saves a new student to database
        /// </summary>
        /// <param name="student">The student model</param>
        /// <returns>The student information with ID</returns>
        StudentModel CreateStudent(StudentModel student);
        /// <summary>
        /// Saves a new teacher to database
        /// </summary>
        /// <param name="teacher">The teacher model</param>
        /// <returns>The teacher information with ID</returns>
        TeacherModel CreateTeacher(TeacherModel teacher);
        /// <summary>
        /// Saves a new section to database
        /// </summary>
        /// <param name="section">The section model</param>
        /// <returns>The section information with ID</returns>
        SectionModel CreateSection(SectionModel section);
        /// <summary>
        /// Save a new subject to database
        /// </summary>
        /// <param name="subject">The subject model</param>
        /// <returns>The subject information with ID</returns>
        SubjectModel CreateSubject(SubjectModel subject);
        /// <summary>
        /// Make a transaction of enrollment and save to database
        /// </summary>
        /// <param name="enrollment">The enrollment model</param>
        /// <returns>The enrollment information</returns>
        EnrollmentModel CreateEnrollment(EnrollmentModel enrollment);
        /// <summary>
        /// Get all the student records from database to student model
        /// </summary>
        /// <returns>The collection of students</returns>
        List<StudentModel> GetAllStudents();
        /// <summary>
        /// Get all the teacher records from database to teacher model
        /// </summary>
        /// <returns>The collection of teachers</returns>
        List<TeacherModel> GetAllTeachers();
        /// <summary>
        /// Get all the section records from database to section model
        /// </summary>
        /// <returns>The collection of sections</returns>
        List<SectionModel> GetAllSections();
        /// <summary>
        /// Get all the subject records from database to subject model
        /// </summary>
        /// <returns>The collection of subjects</returns>
        List<SubjectModel> GetAllSubjects();
        /// <summary>
        /// Get all the records of students who are currently enrolled
        /// </summary>
        /// <returns>The collection of students who are enrolled</returns>
        List<StudentModel> GetEnrolled();
        /// <summary>
        /// Get all the records of students who are not currently enrolled
        /// </summary>
        /// <returns>The collection of students who not are enrolled</returns>
        List<StudentModel> GetUnenrolled();
        /// <summary>
        /// Get if student is enrolled using student ID
        /// </summary>
        /// <param name="StudentID">The student ID</param>
        /// <returns>The enrollment informations</returns>
        EnrollmentModel GetEnrollmentByStudent(int StudentID);
    }
}
