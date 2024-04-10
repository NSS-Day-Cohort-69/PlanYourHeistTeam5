// You will see this if you get this!s
List<TeamMember> teamMembers = new List<TeamMember>();

void Heist()
{
    int bankDifficulty = 100;
    Console.WriteLine("Plan Your Heist!");
   
    string newMemberName = null;
    int newMemberSkillLevel = 0;
    decimal newMemberCourageFactor = -1;

    bool addMore = true;
    
    while (addMore )
    {

        while (newMemberName == null)
        {
            Console.Write("Enter team member's name: ");
            string newName = Console.ReadLine()!.Trim();

            if (string.IsNullOrWhiteSpace(newName))
            {
            
                Console.WriteLine(addMore);
                membersList();
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

    void membersList()
    {
        addMore = false;
        int sum = 0;
        foreach (TeamMember member in teamMembers ){
            sum += member.SkillLevel;
        }
        Console.WriteLine(sum);

        if (sum > bankDifficulty){
            Console.WriteLine("OMG you did it you robbed a bank holy crap!");
        } else {
            Console.WriteLine("JailTIME oopsies");
        }

        // Console.WriteLine($"{teamMembers.Count} members on the team!");

        // foreach (TeamMember teamMember in teamMembers)
        // {
        //     Console.WriteLine($"Name: {teamMember.Name} - Skill Level: {teamMember.SkillLevel} - Courage Factor: {teamMember.CourageFactor}");
        // }
    }

}

Heist();

// delete team member info
// hard code bank difficulty
// sum up skill level
// compare and output message 
