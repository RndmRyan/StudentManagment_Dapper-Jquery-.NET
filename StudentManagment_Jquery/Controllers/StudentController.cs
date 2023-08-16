using X.PagedList;
using Microsoft.AspNetCore.Mvc;
using StudentManagment_Jquery.Models;
using StudentManagment_Jquery.Repository;

public class StudentController : Controller
{
	private readonly StudentRepository _studentRepo;
	public StudentController(StudentRepository studentrepo)
	{
		_studentRepo = studentrepo;
	}

	public ActionResult GetAllStudents()
	{
//		int pageNumber = page ?? 1;
//		int pageSize = 2;

		var students = _studentRepo.ReadAllStudents(); //.ToPagedList(pageNumber, pageSize);
		return View(students);
	}
   
	public ActionResult AddStudent() { return View(); }

	[HttpPost]
	public ActionResult AddStudent(student stud)
	{
		try
		{
			if (ModelState.IsValid)
			{
				_studentRepo.AddStudent(stud);
				ViewBag.Message = "Registered successfully.";
				return RedirectToAction("GetAllStudents");
			}
			return View();
		}
		catch {return View();}
	}
     
	public ActionResult UpdateStudent(int id)
	{
		var student = _studentRepo.ReadStudentById(id);
		if (student != null)
			return View(student);
		return RedirectToAction("GetAllStudents");
	}

	[HttpPost]
	public ActionResult UpdateStudent(int id, student stud)
	{
		try
		{
			_studentRepo.UpdateStudent(stud);
			return RedirectToAction("GetAllStudents");
		}
		catch { return View();}
	}
     
	public ActionResult DeleteStudent(int id)
	{
		try
		{
			if (_studentRepo.DeleteStudent(id))
				ViewBag.AlertMsg = "1 Student Row Deleted";
			return RedirectToAction("GetAllStudents");
		}
		catch {return RedirectToAction("GetAllStudents");}
	}
}