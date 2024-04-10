// Create function, Heist()
    // Console out "Plan Your Heist!"
    // While name (declare before while loop) == null, prompt the user to input a name and store that name in variable, newName
    // While skill (declare before while loop) == null, prompt the user to input a skill level (1 - 30) and store that skill in variable, newSkillLevel
    // While courageFactor (declare before while loop) == null, prompt the user to input a CF(0.0 - 2.0), and store that CF in variable, newCourageFactor

    // Display team member's info (Name: N - Skill: S - Courage Factor: CF) 

void Heist()
{
    Console.WriteLine("Plan Your Heist!");
    TeamMember newTeamMember = new TeamMember()
    {
        Name = null,
        SkillLevel = 0,
        CourageFactor = -1
    };

    while (newTeamMember.Name == null)
    {
        Console.Write("Enter team member's name: ");
        string newName = Console.ReadLine()!.Trim();

        if (string.IsNullOrWhiteSpace(newName))
        {
            Console.WriteLine("Please enter your name :P");
        }
        else
        {
            newTeamMember.Name = newName;
        }
    }

    while (newTeamMember.SkillLevel < 1 || newTeamMember.SkillLevel > 30)
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
                newTeamMember.SkillLevel = newSkillLevel;
                Console.WriteLine(newTeamMember.SkillLevel);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please only enter integers!");
        }
    }
    
    while (newTeamMember.CourageFactor < 0 || newTeamMember.CourageFactor > 2)
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
                newTeamMember.CourageFactor = newCourageFactor;
                Console.WriteLine(newTeamMember.CourageFactor);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please only enter decimals!");
        }
    }
    
    Console.WriteLine($"Name: {newTeamMember.Name} - Skill Level: {newTeamMember.SkillLevel} - Courage Factor: {newTeamMember.CourageFactor}");
}

Heist();