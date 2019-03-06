using System;

namespace CourseGrader
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int[] testScores = new int[5] { 50, 75, 83, 89, 91 };

           string passFail = GradeTestScores(testScores);
            Console.WriteLine(passFail);
            Console.ReadLine();
            // create a method named GradeTestScores that takes a int array of test scores as its parameter and returns a string
            // GradeTestScores will add up these test scores and calculate an average score. 
            // It should then return a string of "pass" or "fail" depending on these two conditions:
            // If the average score is greater than or equal to 70 and no single test score is below 50, then return a message of "pass".
            // If the average score is lower than 70 or at least one test score is below 50, then return a message of "fail".
        }
        public static string GradeTestScores(int[] testScores)
        {
            string pass;
            int sum = 0;
            if (testScores == null || testScores.Length == 0)
                return "fail";
            foreach (int score in testScores)
            {
                sum += score;                                              
            } 
            
            int average = sum / testScores.Length;
            if (average >= 70)
            {
                pass = "pass";                
            }
            else if (average < 70)
            {
                pass = "fail";
            }
            else
            { 
                pass = "fail";                
            }
            for (int i = 0; i < testScores.Length; i++)
            {
                if (testScores[i] < 50)
                    pass = "fail";                           
            }
            return pass;
        }
    }
}
