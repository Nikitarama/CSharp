int currentAssignments = 5;
string currentStudentLetterGrade = "";

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] sophiaExam = [90, 86, 87, 98, 100]; 
int[] andrewExam = [92, 89, 81, 96, 90];
int[] emmaExam = [90, 85, 87, 98, 68];
int[] loganExam = [90, 95, 87, 88, 96];

int[] studentScores = new int[10];
int[] examScores = new int[10];

Console.WriteLine("\nStudent\t\tExam Score\tOverall Grade\tExtra Points\n");
// //'name' could be used to substitute 'currentStudent' but this is to see logic better
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
    else
        continue;


    if (currentStudent == "Sophia")
        examScores = sophiaExam;

    else if (currentStudent == "Andrew")
        examScores = andrewExam;

    else if (currentStudent == "Emma")
        examScores = emmaExam;

    else if (currentStudent == "Logan")
        examScores = loganExam;
    else
        continue;
        //links all name vars to one var "currentStudent" and all the diff array scores to "studentScores"


    // initialize/reset the calculated average of exam + extra credit scores
    decimal studentScore = 0m;
    decimal examScore = 0;
    decimal creditPoints = 0;

    int sum = 0;
    int creditTotal = 0;
    int gradedAssignments = 0;
    int number = 0;
    int credit = 0;


    int examAssignments = currentAssignments;
    //changing the var name to not get confused
    

    foreach (int score in examScores)
    {

        number += score;

    }
    ;


    foreach (int score in studentScores)
    {
        // increment the assignment counter
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            sum += score;

        else
            sum += score / 10;

    }
    ;



    /*student-agnostic array - doesn't belong to a single var, can be used for multiple vars 
        "studentScores = sophiaScores" - a single var assigned to other diff vars so they all attached to one var*/

    studentScore = (decimal)(sum) / examAssignments;
    examScore = (decimal)(number) / examAssignments;
    creditPoints = studentScore - examScore;

    //the last var we used "studentScore" is used to find the letter grade//

    foreach (int score in examScores)
    {
        gradedAssignments = 0;
        // increment the assignment counter
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            credit += score;

        else
            credit += score / 10;

    }
    ;

    creditTotal = credit / examAssignments;


    if (studentScore >= 97)
        currentStudentLetterGrade = "A+";

    else if (studentScore >= 93)
        currentStudentLetterGrade = "A";

    else if (studentScore >= 90)
        currentStudentLetterGrade = "A-";

    else if (studentScore >= 87)
        currentStudentLetterGrade = "B+";

    else if (studentScore >= 83)
        currentStudentLetterGrade = "B";

    else if (studentScore >= 80)
        currentStudentLetterGrade = "B-";

    else if (studentScore >= 77)
        currentStudentLetterGrade = "C+";

    else if (studentScore >= 73)
        currentStudentLetterGrade = "C";

    else if (studentScore >= 70)
        currentStudentLetterGrade = "C-";

    else if (studentScore >= 67)
        currentStudentLetterGrade = "D+";

    else if (studentScore >= 63)
        currentStudentLetterGrade = "D";

    else if (studentScore >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";


    Console.WriteLine($"{currentStudent}:\t\t {examScore}\t\t {studentScore} \t{currentStudentLetterGrade}\t{creditTotal} ({creditPoints})pts");

}

Console.WriteLine("Press the Enter key to continue");
Console.WriteLine($"{studentScores}");
// Console.ReadLine();