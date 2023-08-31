// See https://aka.ms/new-console-template for more information

//Initialized with the value 65.4f
float myFloat = 65.4f;
//Initialized with 0.0f
float myOtherFloat = 0.0f;
//A float variable that will be used to store the result of the division.
float result = 0f;

//An instance of the Random class for generating random numbers.
Random random = new Random();
//A random integer between 2 and 29 (inclusive) generated using the Random.Next method.
int myInt = random.Next(2, 30);

//MyFloat and myOtherFloat are divided by the code. MyOtherFloat being zero, this will result in a DivideByZeroException being raised.
//After handling the caught exception, the user is prompted to provide a new, non-zero value for myOtherFloat and an error message is printed.
//The division is then attempted once more by the code using the updated myOtherFloat value.
try
{
    result = Divide(myFloat, myOtherFloat);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("please enter a number other than zero.");
    myOtherFloat = (float)Convert.ToDouble(Console.ReadLine());

    //The message from the second exception is printed if the second division attempt still produces an exception.
    try
    {
        result = Divide(myFloat, myOtherFloat);
    }
    catch (Exception e2)
    {
        Console.WriteLine(e2.Message);
    }
}
//Whether or whether an exception was raised, this block will always be executed. When the calculations are finished, a message is printed along with the value of the outcome.
finally
{
    Console.WriteLine("Calculations completer with a result of " + result);
}

//The code tries to use the value of myInt to invoke the CheckAge function.
//The user is not old enough to play mature games, according to the message printed if the CheckAge function produces an exception (since myInt is less than 17).
try
{
    CheckAge(myInt);
}
catch
{
    Console.WriteLine($"You are {myInt}, not old enough!");
}

//This procedure verifies that the divisor (y) is zero. If it is, a DivideByZeroException is thrown. In all other cases, it outputs the outcome of dividing x by y
static float Divide(float x, float y)
{
    if(y == 0)
    {
        throw new DivideByZeroException();
    }
    else
    {
        return x / y;
    }
}

//This method checks if the provided age is greater than or equal to 17. If it is, it prints a message indicating that the user can play mature games. Otherwise, it throws an ArgumentException.
static void CheckAge(int age)
{
    if(age >= 17)
    {
        Console.WriteLine($"You are {age}, you can play mature games!");
    }
    else
    {
        throw new ArgumentException();
    }
}