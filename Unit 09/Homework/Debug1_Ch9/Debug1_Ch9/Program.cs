// Creates a HomeworkAssignment class
// instantiates two objects
// and prompts the user for infromation about two courses
using static System.Console;
class DebugNine1
{
    static void Main()
    {
        HomeworkAssignment course1 = new HomeworkAssignment();
        HomeworkAssignment course2 = new HomeworkAssignment();
        string entryString;
        int exercises;

        // Get info for first class
        Write("What class do you have homework for? ");
        //changed from entry to entryString so it had the right string name
        entryString = ReadLine();
        course1.ClassName = entryString;
        Write("How many exercises must you complete? ");
        entryString = ReadLine();//entry 
        int.TryParse(entryString, out exercises);//added out for parsing
        exercises = course1.NumberOfExercises;

        // Get info for another class
        Write("What class do you have homework for? ");
        entryString = ReadLine();
        course2.ClassName = entryString;
        Write("How many exercises must you complete? ");
        entryString = ReadLine();
        int.TryParse(entryString, out exercises);//changed char to int added out for parsing 
        course2.NumberOfExercises = exercises;

        WriteLine("You have {0} minutes of homework for {1}",
              course1.TimeToComplete, course1.ClassName);
        WriteLine("and {0} more minutes for {1}",
              course2.TimeToComplete, course2.ClassName);
    }
}
class HomeworkAssignment
{
    private int numberOfExercises;
    private int timeToComplete;
    // 10 minutes to complete each exercise
    private const int TIME_PER_EXERCISE = 10;



    public string ClassName { get; set; } //add misiing datatype and added ; after set
public int NumberOfExercises
{
    get
    {
        return NumberOfExercises;
    }
    set
    {
        numberOfExercises = value; //changed varaiable from number to value
        CalcCompletionTime();
    }
}
public int TimeToComplete//changed datatype to match 
{
    get
    {
        return timeToComplete;
    }
}
private void CalcCompletionTime()
{
    timeToComplete = numberOfExercises * TIME_PER_EXERCISE;
}
}