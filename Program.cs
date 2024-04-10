// You will see this if you get this!s
List<TeamMember> teamMembers = new List<TeamMember>();

void Heist()
{

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

        Console.WriteLine($"{teamMembers.Count} members on the team!");

        foreach (TeamMember teamMember in teamMembers)
        {
            Console.WriteLine($"Name: {teamMember.Name} - Skill Level: {teamMember.SkillLevel} - Courage Factor: {teamMember.CourageFactor}");
        }
    }

}

Heist();



//create a new list out the heist function 
// after creating list do an .Add 
// call the count function after the blankspace to stop collecting team memebers
// use list.count to get members 
// use a foreach loop to iterate through team members to log out members information
// added addMore to our while loop and set that to true 
// added an if statement to check if addMore is not true then break
