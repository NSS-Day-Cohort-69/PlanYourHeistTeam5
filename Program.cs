// You will see this if you get this!s
List<TeamMember> teamMembers = new List<TeamMember>();
Random random = new Random();

void Heist()
{
    int bankDifficulty = 0;
    
    Console.WriteLine("Plan Your Heist!");
   
    string newMemberName = null;
    int newMemberSkillLevel = 0;
    decimal newMemberCourageFactor = -1;

    bool addMore = true;
    int trials = 0;

    int amountOfFails = 0;
    int amountOfWins = 0;
    
    while (bankDifficulty < 1 || bankDifficulty > 100)
    {
        Console.WriteLine("What is the bank difficulty? (1-100)");

        try
        {
            int response = int.Parse(Console.ReadLine()!.Trim());

            if (response < 1 || response > 100)
            {
                Console.WriteLine("Please enter a valid number!");
            }
            else
            {
                bankDifficulty = response;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please, for the love of God, enter only integers.");
        }
    }

    while (trials < 1){
       Console.WriteLine("How many trial runs do u want? (max 30)");
       
        try
        {
            int response = int.Parse(Console.ReadLine()!);
            
            if (response < 1 || response > 30){
                Console.WriteLine("Bro thats a shitty number!");
        }
        else
        {
            trials = response;
        }
       }
       
        catch (FormatException)
        {
            Console.WriteLine("Please type only integers");
        }
    }
    
    
    while (addMore)
    {
        while (newMemberName == null)
        {
            Console.Write("Enter team member's name: ");
            string newName = Console.ReadLine()!.Trim();

            if (string.IsNullOrWhiteSpace(newName))
            {
                HeistStatus();
                break;
            }
            else
            {
                newMemberName = newName;
            }
        }
        if (!addMore)
            break;

        while (newMemberSkillLevel < 1 || newMemberSkillLevel > 30 && addMore)
        {
            Console.Write("Enter team member's skill level (1-30): ");
            
            try
            {
                int newSkillLevel = int.Parse(Console.ReadLine()!.Trim());
                
                if (newSkillLevel < 1 || newSkillLevel > 30)
                {
                    Console.WriteLine("Please only enter in a skill level 1-30!");
                }
                else
                {
                    newMemberSkillLevel = newSkillLevel;
                  
                }
            }
            
            catch (FormatException)
            {
                Console.WriteLine("Please only enter integers!");
            }
        }

        while (newMemberCourageFactor < 0 || newMemberCourageFactor > 2 && addMore)
        {
            Console.Write("Enter team member's courage factor (0.0 - 2.0): ");
            
            try
            {
                decimal newCourageFactor = decimal.Parse(Console.ReadLine()!.Trim());
                
                if (newCourageFactor < 0 || newCourageFactor > 2)
                {
                    Console.WriteLine("Please only type a courage factorr 0.0 - 2.0!");
                }
                else
                {
                    newMemberCourageFactor = newCourageFactor;
            
                }
            }
            
            catch (FormatException)
            {
                Console.WriteLine("Please only enter decimals!");
            }
        }
        
        TeamMember NewTeamMember = new TeamMember()
        {
           
            Name = newMemberName,
            SkillLevel = newMemberSkillLevel,
            CourageFactor = newMemberCourageFactor
        };

        teamMembers.Add(NewTeamMember);

        newMemberName = null;
        newMemberSkillLevel = 0;
        newMemberCourageFactor = -1;
    }

    void HeistStatus()
    {
        int luck = random.Next(-10, 11);
        int skillSum = 0;
        
        trials--;
        addMore = false;
        bankDifficulty += luck;
        
        foreach (TeamMember member in teamMembers )
        {
            skillSum += member.SkillLevel;
        }
        
        Console.WriteLine(@$"The team's skill level is {skillSum}.
The bank's difficulty is {bankDifficulty}");
        
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        HeistResult(skillSum);
    }

    void HeistResult(int sum)
    {
        if (sum > bankDifficulty)
        {
            amountOfWins++;
            Console.WriteLine("OMG you did it you robbed a bank holy crap!");
        }
        else
        {
            amountOfFails++;
            Console.WriteLine("JailTIME oopsies");
        }


        
        if (trials != 0)
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            HeistStatus();
        }
        else
        {
            Console.WriteLine(@$"Report Card:
            Successes: {amountOfWins}
            Failures: {amountOfFails}");
        }

   
    }

}

Heist();

// Declare two variables, amountOfWins and amountsOfFails. Increment them by one if first HeistResult if/else before the WriteLine

// At the beginning of the program, introduce a while loop that waits for bankDifficulty to be set (1-100)
