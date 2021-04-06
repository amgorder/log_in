using System.Collections.Generic;
using log_in.Models;
using System;

namespace log_in
{
    public class Game
    {
        public Game()
        {
            Profile aaron = new Profile("Aaron", "Password1!");
            Register(aaron);
        }
        public Dictionary<string, Profile> Profiles { get; set; } = new Dictionary<string, Profile>();

        public void Login()
        {
            System.Console.WriteLine("Please enter your username to continue \nUsername:");
            string name = Console.ReadLine();
            System.Console.WriteLine("Password:");
            string password = Console.ReadLine();
            if (Profiles.ContainsKey(name.ToLower()) && Profiles[name.ToLower()].ValidatePassword(password))
            {
                System.Console.WriteLine("Welcome to the game " + name);
            }
            else
            {
                System.Console.WriteLine("That's a NO GO situation ghost writer.");
            }

        }
        public void Register(Profile newProfile)
        {
            Profiles.Add(newProfile.Name.ToLower(), newProfile);
        }
    }
}