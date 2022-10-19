//Chris Martinez
//10/18/22 
// Odd or Even Number - Revamp
//GitHubChallenge - Data Validation and Play Again.
// Relooked at this code, its still a basic and to the point code, 
//the only enhancement I did, was add .ToLower() string method, to ensure
//that if the user decides to type caps and lowercase, the program will still
//intake the informartion of YES or No to replay or end game. 

Console.Clear();
string fin = "yes";
while (fin == "yes" || fin == "Yes" || fin == "YES")
{
    string myNum;
    bool randomNum;
    bool breakout = false;
    int validNum = 0;
    while (breakout == false)
    {
        Console.WriteLine("PLAY ALONG, ENTER A NUMBER:");
        myNum = Console.ReadLine();
        randomNum = Int32.TryParse(myNum, out validNum);

        if (randomNum == true)
        {
            Console.WriteLine("YES!!! THAT IS A VALID NUMBER");
            breakout = true;
        }
        else
        {
            Console.WriteLine("OH NO!!! THAT IS NOT A VALID NUMBER!");
        }
    }
    if (validNum % 2 == 0)
    {
        Console.WriteLine("THAT'S AN EVEN NUMBER!");
    }
    else
    {
        Console.WriteLine("THAT'S AN ODD NUMBER!");
    }
    Console.WriteLine("WANNA PLAY AGAIN YES/ NO?");
    fin = Console.ReadLine().ToLower();
}
Console.WriteLine("GAME OVER!");