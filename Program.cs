using System;

int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
int[] studentScores = new int[10];
string currectStudentLetterGrade = "";

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
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

    if (currentStudentGrade >= 97)
        currectStudentLetterGrade = "A+";
    else if (currentStudentGrade >= 93)
        currectStudentLetterGrade = "A";
    else if (currentStudentGrade >= 90)
        currectStudentLetterGrade = "A-";
    else if (currentStudentGrade >= 87)
        currectStudentLetterGrade = "B+";
    else if (currentStudentGrade >= 83)
        currectStudentLetterGrade = "B";
    else if (currentStudentGrade >= 80)
        currectStudentLetterGrade = "B-";
    else if (currentStudentGrade >= 77)
        currectStudentLetterGrade = "C+";
    else if (currentStudentGrade >= 73)
        currectStudentLetterGrade = "C";
    else if (currentStudentGrade >= 70)
        currectStudentLetterGrade = "C-";
    else if (currentStudentGrade >= 67)
        currectStudentLetterGrade = "D+";
    else if (currentStudentGrade >= 63)
        currectStudentLetterGrade = "D";
    else if (currentStudentGrade >= 60)
        currectStudentLetterGrade = "D-";
    else
        currectStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currectStudentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();