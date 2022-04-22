using Kreta.Models;
using Kreta.Repositories;
using System;
using System.Collections.Generic;

namespace Kreta.Services
{
    public class StudentOfClassService
    {
        SchoolClassesRepo schoolClassesRepo;
        StudentsRepo studentsRepo;

        public StudentOfClassService()
        {
            schoolClassesRepo = new SchoolClassesRepo();
            studentsRepo = new StudentsRepo();
        }

        public List<SchoolClass> Classes
        {
            get
            {
                return schoolClassesRepo.SchoolClasses;
            }
        }

        public List<Student> GetStudentOfClass(int classId)
        {
            List<Student> result=studentsRepo.Students.FindAll(student => student.SchoolClassId == classId);
            result.Sort();
            return result;
        }

        public List<Student> GetStudentOfClass(SchoolClass schoolClass)
        {
            int schoolClassId = schoolClassesRepo.GetSchoolClassId(schoolClass.Grade, schoolClass.GradeType);
            List<Student> result = studentsRepo.Students.FindAll(student => student.SchoolClassId == schoolClassId);
            result.Sort();
            return result;
        }

        public List<Student> GetStudentNoClass()
        {
            return null;
        }

        public void AddStudentToClass(int studentId, int classId)
        {
        }

        public void DeleteStudentFromClass(int studentId)
        {
        }
    }
}
