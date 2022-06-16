using Dapper;
using StudentsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string DBName = "Students";

        /// <summary>
        /// Saves a new student to database
        /// </summary>
        /// <param name="student">The student model</param>
        /// <returns>The student information with ID</returns>
        public StudentModel CreateStudent(StudentModel student)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DBName)))
            {
                DynamicParameters s = new DynamicParameters();
                s.Add("@StudentID", student.StudentID);
                s.Add("@FirstName", student.FirstName);
                s.Add("@MiddleName", student.MiddleName);
                s.Add("@LastName", student.LastName);
                s.Add("@ID",0,dbType: DbType.Int32,direction: ParameterDirection.Output);
                connection.Execute("dbo.spStudents_Create",s,commandType: CommandType.StoredProcedure);
                student.ID = s.Get<int>("@ID");
                return student;
            }
        }
        /// <summary>
        /// Saves a new teacher to database
        /// </summary>
        /// <param name="teacher">The teacher model</param>
        /// <returns>The teacher information with ID</returns>
        public TeacherModel CreateTeacher(TeacherModel teacher)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DBName)))
            {
                DynamicParameters t = new DynamicParameters();
                t.Add("@FirstName", teacher.FirstName);
                t.Add("@LastName", teacher.LastName);
                t.Add("@ID",0, dbType: DbType.Int32,direction: ParameterDirection.Output);
                connection.Execute("dbo.spTeachers_Create", t, commandType: CommandType.StoredProcedure);
                teacher.ID = t.Get<int>("@ID");
                return teacher;
            }
        }
        /// <summary>
        /// Saves a new section to database
        /// </summary>
        /// <param name="section">The section model</param>
        /// <returns>The section information with ID</returns>
        public SectionModel CreateSection(SectionModel section)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DBName)))
            {
                DynamicParameters s = new DynamicParameters();
                s.Add("@SectionName", section.SectionName);
                s.Add("@SectionSize", section.SectionSize);
                s.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spSections_Create", s, commandType: CommandType.StoredProcedure);
                section.ID = s.Get<int>("@ID");
                return section;
            }
        }
        /// <summary>
        /// Save a new subject to database
        /// </summary>
        /// <param name="subject">The subject model</param>
        /// <returns>The subject information with ID</returns>
        public SubjectModel CreateSubject(SubjectModel subject)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DBName)))
            {
                DynamicParameters s = new DynamicParameters();
                s.Add("@SubjectCode", subject.SubjectCode);
                s.Add("@SubjectTitle", subject.SubjectTitle);
                s.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spSubjects_Create", s, commandType: CommandType.StoredProcedure);
                subject.ID = s.Get<int>("@ID");
                return subject;
            }
        }
        /// <summary>
        /// Get all the student records from database to student model
        /// </summary>
        /// <returns>The collection of students</returns>
        public List<StudentModel> GetAllStudents()
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DBName)))
            {
                return connection.Query<StudentModel>("dbo.spStudents_GetAll").ToList();
            }
        }
        /// <summary>
        /// Get all the records of students who are currently enrolled
        /// </summary>
        /// <returns>The collection of students who are enrolled</returns>
        public List<StudentModel> GetEnrolled()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DBName)))
            {
                return connection.Query<StudentModel>("dbo.spStudents_GetByEnrolled").ToList();
            }
        }
        /// <summary>
        /// Get all the records of students who are not currently enrolled
        /// </summary>
        /// <returns>The collection of students who not are enrolled</returns>
        public List<StudentModel> GetUnenrolled()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DBName)))
            {
                return connection.Query<StudentModel>("dbo.spStudents_GetByUnenrolled").ToList();
            }
        }
        /// <summary>
        /// Get all the teacher records from database to teacher model
        /// </summary>
        /// <returns>The collection of teachers</returns>
        public List<TeacherModel> GetAllTeachers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DBName)))
            {
                return connection.Query<TeacherModel>("dbo.spTeachers_GetAll").ToList();
            }
        }
        /// <summary>
        /// Get all the section records from database to section model
        /// </summary>
        /// <returns>The collection of sections</returns>
        public List<SectionModel> GetAllSections()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DBName)))
            {
                return connection.Query<SectionModel>("dbo.spSections_GetAll").ToList();
            }
        }
        /// <summary>
        /// Get all the subject records from database to subject model
        /// </summary>
        /// <returns>The collection of subjects</returns>
        public List<SubjectModel> GetAllSubjects()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DBName)))
            {
                return connection.Query<SubjectModel>("dbo.spSubjects_GetAll").ToList();
            }
        }
        /// <summary>
        /// Make a transaction of enrollment and save to database
        /// </summary>
        /// <param name="enrollment">The enrollment model</param>
        /// <returns>The enrollment information</returns>
        public EnrollmentModel CreateEnrollment(EnrollmentModel enrollment)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DBName)))
            {
                foreach (SubjectModel subject in enrollment.Subjects)
                {
                    DynamicParameters enroll = new DynamicParameters();
                    enroll.Add("@StudentID", enrollment.Student.ID);
                    enroll.Add("@SubjectID", subject.ID);
                    enroll.Add("@SectionID", enrollment.Section.ID);
                    connection.Execute("dbo.spEnrollees_Create", enroll, commandType: CommandType.StoredProcedure);
                }
                return enrollment;
            }
        }
        /// <summary>
        /// Get if student is enrolled using student ID
        /// </summary>
        /// <param name="StudentID">The student ID</param>
        /// <returns>The enrollment informations</returns>
        public EnrollmentModel GetEnrollmentByStudent(int StudentID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DBName)))
            {
                EnrollmentModel enrollment = new EnrollmentModel();
                enrollment.Student = connection.Query<StudentModel>("dbo.spEnrollees_GetByStudentID", new { StudentID }, commandType: CommandType.StoredProcedure).First();
                enrollment.Subjects = connection.Query<SubjectModel>("dbo.spEnrollees_GetByStudentID", new { StudentID }, commandType: CommandType.StoredProcedure).ToList();
                enrollment.Section = connection.Query<SectionModel>("dbo.spEnrollees_GetByStudentID", new { StudentID }, commandType: CommandType.StoredProcedure).First(); ;
                enrollment.Date = connection.Query<EnrollmentModel>("dbo.spEnrollees_GetByStudentID", new { StudentID }, commandType: CommandType.StoredProcedure).First().Date;
                return enrollment;
                //return connection.Query<EnrollmentModel>("dbo.spEnrollees_GetByStudentID").ToList();
            }
        }
    }
}
