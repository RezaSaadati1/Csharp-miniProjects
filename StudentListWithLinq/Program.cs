using System;
using System.Linq;

namespace StudentListWithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            a => Active - score = morethan 80 - city = NYC
            b => Score morethan 80 or lives in CA
            c => Project to small class and the first char of nema is 'B'
            d => Inactive students in descending order of score
            f => Average marks of the whole class
            x => Average scores for people who live in California are active and have the letter R or D in their name
            */
            var studentList = StudentDB.GetStudentsFromDB();


            // var a = studentList.Where(x => x.IsActive == true).Where(x => x.Score > 80)
            //                     .Where(x => x.City == "NYC").Select(x => x.StudentName);

            var a = from Student in studentList
                    where Student.IsActive == true && Student.Score > 80 && Student.City == "NYC"
                    select Student.StudentName;



            // var b = studentList.Where(x => x.Score > 80 || x.City == "CA").Select(x => x.StudentName);

            // var b = from Student in studentList
            //         where Student.Score > 80 || Student.City == "CA"
            //         select Student.StudentName; 



            // var c = studentList.Where(x => x.StudentName.Contains("B"))
            //                     .Select(x => new MinimalStudent
            //                     {
            //                         StudentName = x.StudentName,
            //                         Score = x.Score
            //                     }).Select(x => x.StudentName);

            // var c = from Student in studentList
            //         where Student.StudentName.Contains("B")
            //         select new MinimalStudent
            //         {
            //             StudentName = Student.StudentName,
            //             Score = Student.Score
            //         };


            // var d = studentList.OrderByDescending(x => x.Score).Where(x => x.IsActive == false)
            //                     .Select(x => x.StudentName);

                    // var d = from Student in studentList
                    //         where Student.IsActive == false
                    //         orderby Student.Score descending 
                    //         select Student.StudentName;




                    // var f = studentList.All(x => x.Score);


                    // var x = studentList.Where(x => x.City == "CA" && x.IsActive == true && 
                    //                     (x.StudentName.Contains("R") || x.StudentName.Contains("D"))).Select(x => x.Score).Average().ToString();

                    // var x = (from Student in studentList
                    //         where Student.City == "CA" &&
                    //             Student.IsActive == true &&
                    //             (Student.StudentName.Contains("R")|| Student.StudentName.Contains("D"))
                    //             select Student.Score).Average().ToString();

            foreach (var item in a)
            {
                Console.Clear();
                Console.WriteLine(item);
            }

            // Just to show the result 'x' :
            // Console.WriteLine(x);

        }
    }
}
