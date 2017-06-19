using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    public string Name { get; set; }

    public int Age { get; set; }

    public List<int> Grades { get; set; }
}

public class JSONstringify
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();
        var students = new List<Student>();

        while (inputLine != "stringify")
        {
            var data = inputLine.Split(new[] { ' ', ':', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var name = data[0];
            var age = int.Parse(data[1]);
            var grades = data.Skip(2).ToList();

            var newStudent = new Student
            {
                Name = name,
                Age = age,
                Grades = grades.Select(int.Parse).ToList()
            };
            
            students.Add(newStudent);
            inputLine = Console.ReadLine();
        }

        var output = "";
        output += "[";

        for (int i = 0; i < students.Count; i++)
        {
            var currentStudent = students[i];
            output += "{";

            output += "name:\"" + currentStudent.Name + "\",";
            output += "age:" + currentStudent.Age + ",";
            output += "grades:" + "[" + string.Join(", ", currentStudent.Grades) + "]";

            if (i == students.Count - 1)
            {
                output += "}";
            }
            else
            {
                output += "},";
            }
        }
        output += "]";

        Console.WriteLine(output);
    }
}