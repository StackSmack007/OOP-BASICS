using System;

namespace _03_Mankind
{
    public class StartUp
    {
        static void Main()
        {
            string[] studentInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] workerInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            try
            {
                Student student = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);
                Worker worker = new Worker(workerInfo[0], workerInfo[1], decimal.Parse(workerInfo[2]), int.Parse(workerInfo[3])); 
                Console.WriteLine(student+Environment.NewLine);
                Console.WriteLine(worker);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}