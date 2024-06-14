namespace practice_h
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter youre Year:");
            int yearofbirth = Convert.ToInt32(Console.ReadLine());

            int age = 2024 - yearofbirth;
            string stage= StageofPerson(age);

           string generation= Generation(age);          
           
            Console.WriteLine($"{age} years old, {generation}, {stage}");
        }

        public static string Generation(int age)
        {
            if (age >= 79 && age <= 96)
            {
                return "The Silent Generation";
            }
            else if (age >= 60 && age <= 78)
            {
                return "Baby Boomers";
            }
            else if (age >= 44 && age <= 59)
            {
                return "Gen X";
            }
            else if (age >= 28 && age <= 43)
            {
                return "Millennials";
            }
            else if (age >= 12 && age <= 27)
            {
                return "Gen Z";
            }
            else if (age >= 0 && age <= 11)
            {
                return "Gen Alpha";
            }
            else
            {
                return "Unknown Generation";
            }
        }

        public static string StageofPerson(int age)
        {
            if (age >= 0 && age <= 3)
            {
                return "Infant";
            }
            else if (age >= 4 && age <= 6)
            {
                return "Early Childhood";
            }
            else if (age == 7 || age == 8)
            {
                return "Middle Childhood";
            }
            else if (age >= 9 && age <= 11)
            {
                return "Late Childhood";
            }
            else if (age >= 12 && age <= 20)
            {
                return "Adolescence";
            }
            else if (age >= 21 && age <= 35)
            {
                return "Early Adulthood";
            }
            else if (age >= 36 && age <= 50)
            {
                return "Midlife";
            }
            else if (age >= 51 && age <= 80)
            {
                return "Mature Adulthood";
            }
            else if (age > 80)
            { 
                return "Late Adulthood";
            }
            else
            {
                return "Unknown Stage";
            }
        }
           
    }
}
