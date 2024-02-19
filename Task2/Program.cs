 char CheckGrade(int grade)
{
    if (grade >= 90) return 'A';
    else if (grade >= 80 && grade <= 89) return 'B';
    else if (grade >= 70 && grade <= 79) return 'C';
    else if (grade >= 60 && grade <= 69) return 'D';
    else return 'F';
     
}
Console.Write("Enter a student's grade: ");
int grade=int.Parse(Console.ReadLine());
Console.WriteLine(CheckGrade(grade)); 