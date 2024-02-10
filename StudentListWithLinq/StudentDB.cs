using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentListWithLinq
{
    public class StudentDB
    {
         public static IQueryable<Student> GetStudentsFromDB()
        {
            return new[] {
                new Student() {StudentId = 1, StudentName = "Jon aa", Score = 77, City = "NYC", IsActive = false},
                new Student() {StudentId = 2, StudentName = "Saman", Score = 85, City = "NYC", IsActive = true},
                new Student() {StudentId = 3, StudentName = "Rayan", Score = 33, City = "CA", IsActive = false},
                new Student() {StudentId = 4, StudentName = "Baran", Score = 49, City = "NYC", IsActive = true},
                new Student() {StudentId = 5, StudentName = "Razi", Score = 54, City = "CA", IsActive = true},
                new Student() {StudentId = 6, StudentName = "Donya", Score = 96, City = "CA", IsActive = true},
            }.AsQueryable();
        }
    }
}