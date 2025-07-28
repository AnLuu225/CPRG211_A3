using System;

namespace problemdomain
{
    [Serializable]
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // Initializes a User object.
        public User(int id, string name, string email, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
        }

        // Checks if the passed password is correct.
        public bool IsCorrectPassword(string password)
        {
            return Password == password;
        }

        // Overrides object equality check.
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            User other = (User)obj;
            return Id == other.Id &&
                   Name == other.Name &&
                   Email == other.Email;
        }

        // Override hash code to match Equals
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Email);
        }

        public override string ToString()
        {
            return $"User(Id={Id}, Name={Name}, Email={Email})";
        }
    }
}
