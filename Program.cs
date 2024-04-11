// You will see this if you get this!s
List<TeamMember> teamMembers = new List<TeamMember>();
Random random = new Random();

void Heist()
{
    int bankDifficulty = 100;
    int luck = random.Next(-10, 11);
    Console.WriteLine("Plan Your Heist!");
   
    string newMemberName = null;
    int newMemberSkillLevel = 0;
    decimal newMemberCourageFactor = -1;

    bool addMore = true;
    
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
        addMore = false;
        bankDifficulty += luck;
        int skillSum = 0;
        foreach (TeamMember member in teamMembers ){
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
            Console.WriteLine("OMG you did it you robbed a bank holy crap!");
        }
        else
        {
            Console.WriteLine("JailTIME oopsies");
        }
    }

}

Heist();

// Declare random class and function
    // Declare luck variable and initialize it as a random number between (-10 and 10) using the .Next method
    // In function, HeistStatus, add luck to bank difficulty
    // In function, HeistStatus, display team's combined skill level AND bank's difficulty level (luck included!)
        // After, HeistStatus, runs, wait for user to push any key (ReadKey), then run HeistResult()