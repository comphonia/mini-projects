using System;

namespace Project5
{
    class Program
    {
        // Name: Everistus Akpabio
        // Date created: 3/6/2018
        // Purpose: Grade processing app for teachers

        // boolean accessible to all methods to control output
        static bool isFound;
        static void Main(string[] args)
        {
            //Declaring and initializing grade array
            double[] exam1Grades = { 100, 96, 83, 79, 100, 96, 83, 79, 100, 96 };
            //Declaring and initializing grade array
            double[] exam2Grades = { 100, 96, 83, 79, 90, 65.5, 73.8, 89, 70, 86 };
            //Declaring and initializing grade array
            double[] exam3Grades = { 70, 66, 73, 69, 80.5, 55, 70, 69, 90, 56 };
            //Declaring and initializing students array
            String[] students = { "Cherilyn", "Stefani", "Whitney", "Aretha", "Mariah", "Adele", "Beyonce", "Tina", "Diana", "Ella" };
            //Declaring and initializing student ID array
            String[] studentID = { "001", "002", "003", "004", "005", "006", "007", "008", "009", "010" };
            //Declaring array for student averages
            double[] studentAverages = new double[students.Length];

            //Average grade for exam 1
            Console.WriteLine("the average for exam 1 is = " + CalculateExamAverage(exam1Grades));
            //Average grade for exam 2
            Console.WriteLine("the average for exam 1 is = " + CalculateExamAverage(exam2Grades));
            //Average grade for exam 3
            Console.WriteLine("the average for exam 1 is = " + CalculateExamAverage(exam3Grades));

            //For loop to calculate averages
            for (int i = 0; i <students.Length; i++)
            {
                //calls the method and sends arguments
                CalculateStudentAverage(exam1Grades[i], exam2Grades[i], exam3Grades[i]);
            }


            //declaring a string var for input
            string userInput = "";
            //variable for storing average grade
            double avgGrade = 0;

            //Do looping while the user has not quit
            do
            {
                //sets the static bool to false
                isFound = false;
                //Spacing
                Console.WriteLine("");
                //asks for user input
                Console.WriteLine("Enter a search string or enter \"quit\" to quit application : ");
                //user input stores in variable
                userInput = Console.ReadLine();
                //calls a method and sends arguments
                int matchIndex = FindStudentIndex(students, studentID, userInput);
                // is bool is true
                if (isFound == true)
                {
                    // average grade defined
                    avgGrade = (exam1Grades[matchIndex] + exam2Grades[matchIndex] + exam3Grades[matchIndex]) / 3;
                    //Shows the index of the matching name
                    Console.WriteLine("The student found is : " + students[matchIndex] + "and the exam average is : " + avgGrade.ToString("F2"));
                }

            }
            //Loops while not quit
            while (!userInput.Equals("quit"));

            //Hold Output
            Console.ReadKey();
        }

        // Method for exam average
        private static double CalculateExamAverage(double[] examAverage)
        {
            //variable to store average
            double exAverage = 0;
            //for loop to get elements in an array
            for (int i = 0; i < examAverage.Length; i++)
            {
                //Add element values to average variable
                exAverage += examAverage[i];
            }

            // return the average as value/array length
            return exAverage / examAverage.Length;

        }
        // Method for student average
        private static double CalculateStudentAverage(double exam1, double exam2, double exam3)
        {
            //variable to store average
            double stAverage = 0;
            // calculates the average
            stAverage = (exam1 + exam2 + exam3) / 3;
            //returns average
            return stAverage;
        }
        // Method for finding index
        private static int FindStudentIndex(string[] names, string[] ID, string input)
        {
            //variable declared 
            int match = 0;
            //for loop to get elements in an array
            for (int i = 0; i < names.Length; i++)
            {
                //if both arrays contain user input
                if (names[i].Contains(input) || ID[i].Contains(input))
                {
                    // set match to index
                    match = i;
                    // set bool to true
                    isFound = true;

                }

            }
            // If bool is not true after search, output not found
            if (isFound == false && !input.Equals("quit"))
            {
                //Spacing
                Console.WriteLine("");
                //outputs message
                Console.WriteLine("A student was not found based on your criteria");
                // 
                match = names.Length;
            }
            // return type var as int
            return match;

        }

    }
}
