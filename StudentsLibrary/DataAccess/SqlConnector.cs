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
        public List<StudentModel> GetAllStudents()
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DBName)))
            {
                return connection.Query<StudentModel>("dbo.spStudents_GetAll").ToList();
            }
        }
        public List<TeacherModel> GetAllTeachers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DBName)))
            {
                return connection.Query<TeacherModel>("dbo.spTeachers_GetAll").ToList();
            }
        }
        public List<SectionModel> GetAllSections()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DBName)))
            {
                return connection.Query<SectionModel>("dbo.spSections_GetAll").ToList();
            }
        }
        public List<SubjectModel> GetAllSubjects()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DBName)))
            {
                return connection.Query<SubjectModel>("dbo.spSubjects_GetAll").ToList();
            }
        }
        public List<StudentModel> GetEnrolled()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DBName)))
            {
                return connection.Query<StudentModel>("dbo.spStudents_GetByEnrolled").ToList();
            }
        }
        public List<StudentModel> GetUnenrolled()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DBName)))
            {
                return connection.Query<StudentModel>("dbo.spStudents_GetByUnenrolled").ToList();
            }
        }
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
