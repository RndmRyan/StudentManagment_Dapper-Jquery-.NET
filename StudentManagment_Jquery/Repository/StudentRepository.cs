using Dapper;
using Microsoft.Data.SqlClient;
using StudentManagment_Jquery.Models;
using System.Data;

namespace StudentManagment_Jquery.Repository
{
	public class StudentRepository
	{
		private readonly string _connectionString;
		public StudentRepository(IConfiguration configuration)
		{
			_connectionString = configuration.GetConnectionString("SqlConn");
		}

		private IDbConnection OpenConnection()
		{
			SqlConnection connection = new SqlConnection(_connectionString);
			connection.Open();
			return connection;
		}

		//-------  CREATE
		public void AddStudent(student stud)
		{
			try
			{

				var parameters = new {firstName = stud.FirstName, lastName = stud.LastName, dob = stud.dob, Email = stud.Email, Phone = stud.Phone};
				using IDbConnection dbConnection = OpenConnection();
				dbConnection.Execute("InsertStudent", parameters, commandType: CommandType.StoredProcedure);
			}
			catch (Exception ex) {throw ex;}
		}
		
		//------ READ
		public List<student> ReadAllStudents()
		{
			try
			{
				using IDbConnection dbConnection = OpenConnection();
				IList<student> studentList = dbConnection.Query<student>("GetAllStudents", commandType: CommandType.StoredProcedure).ToList();
				return (List<student>)studentList;
			}
			catch (Exception){throw;}
		}

		public student ReadStudentById(int studentid)
		{
			using IDbConnection dbConnection = OpenConnection();
			var parameters = new { student_id = studentid};
			var student = dbConnection.QueryFirstOrDefault<student>("GetStudent", parameters, commandType: CommandType.StoredProcedure);
			return student;
		}

		//-----------  UPDATE    
		public void UpdateStudent(student stud)
		{
			try
			{
				using IDbConnection dbConnection = OpenConnection();
				dbConnection.Execute("UpdateStudent", stud, commandType: CommandType.StoredProcedure);
			}
			catch (Exception) {throw;}

		}
		//----------  DELETE    
		public bool DeleteStudent(int student_id)
		{
			try
			{
				DynamicParameters param = new DynamicParameters();
				param.Add("@student_id", student_id);
				using IDbConnection dbConnection = OpenConnection();
				dbConnection.Execute("DeleteStudent", param, commandType: CommandType.StoredProcedure);
				return true;
			}
			catch (Exception ex) {throw ex;}
		}
	}
}
