using System;

class GradeEvaluation
{
    static void Main()
    {


        //Assignment 2


        string name = "Mohamed Yasser GradeEvaluation";

        Console.WriteLine("**************************************");
        Console.WriteLine("*                                    *");
        Console.WriteLine("*       " + name + "                 *");
        Console.WriteLine("*                                    *");
        Console.WriteLine("**************************************");


        int[,] grades = new int[6, 4];
        int[] studentIDs = new int[6];

        InputData(studentIDs, grades);
        PrintGradeEvaluation(grades);
        PrintStudentTotalGrades(grades, studentIDs);
        PrintFailingStudents(grades, studentIDs);
    }

    static void InputData(int[] studentIDs, int[,] grades)
    {
        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Enter ID for student {i + 1}: ");
            studentIDs[i] = int.Parse(Console.ReadLine());
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Enter grade for subject {j + 1} of student {studentIDs[i]}: ");
                grades[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static string GetGradeEvaluation(int grade)
    {
        if (grade >= 85) return "A";
        if (grade >= 70) return "B";
        if (grade >= 65) return "C";
        if (grade >= 50) return "D";
        return "F";
    }

    static void PrintGradeEvaluation(int[,] grades)
    {
        Console.WriteLine("Grade Evaluation for each subject:");
        for (int i = 0; i < grades.GetLength(0); i++)
        {
            Console.Write($"Student {i + 1}: ");
            for (int j = 0; j < grades.GetLength(1); j++)
            {
                Console.Write(GetGradeEvaluation(grades[i, j]) + " ");
            }
            Console.WriteLine();
        }
    }

    static void PrintStudentTotalGrades(int[,] grades, int[] studentIDs)
    {
        Console.WriteLine("Total Grade Evaluation for each student:");
        for (int i = 0; i < grades.GetLength(0); i++)
        {
            int total = 0;
            for (int j = 0; j < grades.GetLength(1); j++)
            {
                total += grades[i, j];
            }
            string eval = GetGradeEvaluation(total / grades.GetLength(1));
            Console.WriteLine($"Student {studentIDs[i]} total evaluation: {eval}");
        }
    }

    static void PrintFailingStudents(int[,] grades, int[] studentIDs)
    {
        Console.WriteLine("Students failing more than 2 subjects:");
        for (int i = 0; i < grades.GetLength(0); i++)
        {
            int failCount = 0;
            for (int j = 0; j < grades.GetLength(1); j++)
            {
                if (grades[i, j] < 50) failCount++;
            }
            if (failCount > 2)
            {
                Console.WriteLine($"Student {studentIDs[i]} failed in more than two subjects.");
            }
        }
    }
}
