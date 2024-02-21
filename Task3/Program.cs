
var st1 = new Student()
{
    Name = "Alijon Sattorov",
    GradeLevel = 11,
    TestScores = new int [] { 80, 70, 60, 45, 100 } 

};

var st2 = new Student();
st2.Name = "Muhammad"; 
st2.GradeLevel = 9;
st2.TestScores = new int [] { 100, 55, 80, 20, 60 };

var st3 = new Student();
st3.Name = "Abdulloh";
st3.GradeLevel = 11;
st3.TestScores = new int[] { 90, 95, 100, 80, 60 };



var average1 = st1.GetAverage();
if (average1>=85)
{
    Console.WriteLine($"Congratulations {st1.Name} on achieving above average scores {average1} in grade {st1.GradeLevel}\r\nKeep up the good work!");
} 
else if (average1>=70 && average1<85)
{
    Console.WriteLine($"{st1.Name}, if you're having difficulties with your studies, don't hesitate to\r\nseek help. Your current average score is {average1} in grade {st1.GradeLevel}.");
}
else
{
    Console.WriteLine($"{st1.Name}, please learn more and if needs help, ask teachers.\nYour current average score is {average1} in grade {st1.GradeLevel}.");
}
Console.WriteLine("-----------------------------------------------------------");  


var average2 = st2.GetAverage();

if (average2 >= 85)
{
    Console.WriteLine($"Congratulations {st2.Name} on achieving above average scores {average2}" +
        $" in grade {st2.GradeLevel}\r\nKeep up the good work!");
}
else if (average2 >= 70 && average2 < 85)
{
    Console.WriteLine($"{st2.Name}, if you're having difficulties with your studies, don't hesitate to" +
        $"\r\nseek help. Your current average score is {average2} in grade {st2.GradeLevel}.");
}
else
{
    Console.WriteLine($"{st2.Name}, please learn more and if needs help, ask teachers." +
        $"\nYour current average score is {average2} in grade {st2.GradeLevel}.");
}
Console.WriteLine("-----------------------------------------------------------");

var average3 = st3.GetAverage();

if (average3 >= 85)
{
    Console.WriteLine($"Congratulations {st3.Name} on achieving above average scores {average3}" +
        $" in grade {st3.GradeLevel}\r\nKeep up the good work!");
}
else if (average3 >= 70 && average3 < 85)
{
    Console.WriteLine($"{st3.Name}, if you're having difficulties with your studies, don't hesitate to" +
        $"\r\nseek help. Your current average score is {average3} in grade {st3.GradeLevel}.");
}
else
{
    Console.WriteLine($"{st3.Name}, please learn more and if needs help, ask teachers." +
        $"\nYour current average score is {average3} in grade {st3.GradeLevel}.");
}
class Student
{
    public string Name;
    public int GradeLevel;
    public int[] TestScores;

    public double GetAverage()
    {
        int sum = 0;
        for (int i = 0; i < TestScores.Length; i++)
        {
            sum += TestScores[i];
        }
        return sum / (double)TestScores.Length;
    }
}