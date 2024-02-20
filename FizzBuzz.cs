/*
Made this code regarding the "FizzBuzz" challenge
which it demands a crescent list going from the number 1 to a 100
and everytime a number is divisble by 3 the console output of the number 
needs to be accompanied by the word "Fizz".
If the number is divisible by 5 then the word "Buzz" 
will show in the same line as the number 
and "FizzBuzz" if is divisible by both 3 and 5.
*/
for (int i = 1; i <= 100; i++) 
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }   
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    }
    else if (i % 5 == 0)
    {    
        Console.WriteLine($"{i} - Buzz");
    }
    else
    {    
        Console.WriteLine(i);
    }
}


