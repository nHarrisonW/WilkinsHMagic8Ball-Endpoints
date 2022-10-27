//N. Harrison Wilkins
//10-27-2022
//MAGIC 8BALL CONROLLER - ENDPOINTS
//THIS PROGRAM WILL ALLOW THE USER TO "SPIN" THE MAGIC 8 BALL AND GET A RANDOM ANSWER EVERYTIME,  RUNNING THROUGH A WEB API
//PEER REVIEW BY : Fredddy Aguilar - The program takes the 8 ball mini challenge and converts it into API format.
// The program takes the randomized function and gives back the output of a randomized answer on Postman just like a real magic 8 ball!
// Program works as intended and the code is short and sweet! Good job!


using Microsoft.AspNetCore.Mvc;

namespace WilkinsHMagic8Ball_Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class Magic8BallController : ControllerBase
{
    [HttpGet]
    [Route ("spin")]
    public string Magic8BallGame()
    {
        Random rnd = new Random();
        string[] rolls = {"YES...", "NO...", "PROBABLY...", "PROBABLY NOT...", "MAYBE SO...", "MAYBE NOT...", "WHO CARES..?", "DON'T ASK ME...", "COULDN'T TELL YOU...", "BE PATIENT...", "SOMETIMES IT IS BETTER TO GO IN BLIND...", "DON'T LET THIS TROUBLE YOU..."};
        return rolls[rnd.Next(rolls.Length)];
    }
}
