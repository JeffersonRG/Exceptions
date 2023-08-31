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

//The code attempts to divide myFloat by myOtherFloat. Since myOtherFloat is 0.0f, this will throw a DivideByZeroException.
//The caught exception is then handled by printing an error message and prompting the user to enter a new non- zero value for myOtherFloat.
//The code then attempts the division again using the new myOtherFloat value.
try
{
    result = Divide(myFloat, myOtherFloat);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("please enter a number other than zero.");
    myOtherFloat = (float)Convert.ToDouble(Console.ReadLine());

    //If the second division attempt still results in an exception, the message from the second exception is printed.
    try
    {
        result = Divide(myFloat, myOtherFloat);
    }
    catch (Exception e2)
    {
        Console.WriteLine(e2.Message);
    }
}
//This block will always execute regardless of whether an exception was thrown or not. It prints a message indicating the completion of calculations and the value of the result.
finally
{
    Console.WriteLine("Calculations completer with a result of " + result);
}

//The code attempts to call the CheckAge method with the myInt value.
//If the CheckAge method throws an exception (because myInt is less than 17), it catches the exception and prints a message indicating that the user is not old enough to play mature games.
try
{
    CheckAge(myInt);
}
catch
{
    Console.WriteLine($"You are {myInt}, not old enough!");
}

//This method checks if the divisor (y) is zero. If it is, it throws a DivideByZeroException. Otherwise, it returns the result of dividing x by y.
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