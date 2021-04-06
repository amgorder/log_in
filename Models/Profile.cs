

namespace log_in.Models
{
    //anything contained inside os this class is considered a Member
    public class Profile
    {
        public Profile(string name, string password)
        {
            Name = name;
            Password = password;

        }

        public string Name { get; set; }
        //private can only be accessed by a Member of this class
        private string Password { get; set; }

        public bool ValidatePassword(string input)
        {
            return input == Password;
        }

    }
}