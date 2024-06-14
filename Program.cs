﻿namespace practice_h
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter youre Year:");
            int yearofbirth = Convert.ToInt32(Console.ReadLine());

            int age = 2024 - yearofbirth;
            string generation= "";
            string stage= "";

            Generation(age,generation);
            StageofPerson(age, stage,generation);
        }
        public static void Generation(int age, string generation)
        {
            if (age >= 79 && age <= 96)
            {
                generation = "The Silent Generation";
            }
            else if (age >= 60 && age <= 78)
            {
                generation = "Baby Boomers";
            }
            else if (age >= 44 && age <= 59)
            {
                generation = "Gen X";
            }
            else if (age >= 28 && age <= 43)
            {
                generation = "Millenials";
            }
            else if (age >= 12 && age <= 27)
            {
                generation = "Gen Z";
            }
            else if (age >= 0 && age <= 11)
            {
                generation = "Gen Alpha";
            }

        }
        public static void StageofPerson(int age, string stage, string generation)
        {
            if (age >= 0 && age <= 3)
            {
                stage = "Infant";
            }
            else if (age >= 4 && age <= 6)
            {
                stage = "Early Childhood";
            }
            else if (age == 7 || age == 8)
            {
                stage = "Middle Childhood";
            }
            else if (age >= 9 && age <= 11)
            {
                stage = "Late Childhood";
            }
            else if (age >= 12 && age <= 20)
            {
                stage = "Adolescence";
            }
            else if (age >= 21 && age <= 35)
            {
                stage = "Early Adulthood";
            }
            else if (age >= 36 && age <= 50)
            {
                stage = "Midlife";
            }
            else if (age >= 51 && age <= 80)
            {
                stage = "Mature Adulthood";
            }
            else if (age > 80)
            {
                stage = "Late Adulthood";
            }

            Console.WriteLine($"{age} years old, {generation}, {stage}");

        }
    }
}
