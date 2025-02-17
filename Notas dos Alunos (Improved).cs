﻿// initialize variables - graded assignments 

int examAssignments = 5;

int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
int[] andrewScores = [92, 89, 81, 96, 90, 89];
int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganScores = [90, 95, 87, 88, 96, 96];

// Student names
string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan"];

int[] studentScores = [];

string currentStudentLetterGrade = "";

// Write the Report Header to the console
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        // assign Sophia's scores to the studentScores array 
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        // assign Andrew's scores to the studentScores array 
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        // assign Emma's scores to the studentScores array 
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        // assign Logan's scores to the studentScores array
        studentScores = loganScores;



    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;
    decimal examScore = 0;
    
    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;
    decimal examScoreGrade = 0;
    decimal porcentage = 0;

    int gradedAssignments = 0;
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
        {
            // add the exam score to the sum
            sumAssignmentScores += score;
            examScore += score;
        }
        else
        {
            // add the extra credit points to the sum - bonus points equal to 10% of an exam score
            porcentage += (decimal)score / 100 * 10 / 5;
            sumAssignmentScores += score / 10;
        }
    }

    //Value conversion calculations
    examScoreGrade = (decimal)examScore / examAssignments;
    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{examScoreGrade}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t({porcentage} pts)");
}