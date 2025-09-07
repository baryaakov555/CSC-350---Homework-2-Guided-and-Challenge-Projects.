using System;

int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
int[] studentScores = new int[10];

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emaa")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int sumOfAssignmentScores = 0;
    decimal currentStudentGrade = 0;

    foreach (int score in studentScores)
    {
        sumOfAssignmentScores += score;
    }

    currentStudentGrade = (decimal)sumOfAssignmentScores / currentAssignments;

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t?");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();