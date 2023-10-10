namespace PersonAgeDeterminationProblem
{
  
        public class AgeCategoryDetermination
        {
            public static string DetermineAgeCategory(int age)
            {
                if (age >= 1 && age <= 14)
                {
                    return "Children";
                }
                else if (age >= 15 && age <= 24)
                {
                    return "Youth";
                }
                else if (age >= 25 && age <= 64)
                {
                    return "Adults";
                }
                else if (age >= 65)
                {
                    return "Seniors";
                }
                else
                {
                    throw new InvalidAgeException("Invalid Age: Age should be a positive number.");
                }
            }
        

        public class InvalidAgeException : Exception
        {
            public InvalidAgeException(string message) : base(message)
            {
            }
        }
        public static void Main(string[] args)
        {
            AgeCategoryDetermination AgeCategoryDetermination = new AgeCategoryDetermination();
        }
    }
}