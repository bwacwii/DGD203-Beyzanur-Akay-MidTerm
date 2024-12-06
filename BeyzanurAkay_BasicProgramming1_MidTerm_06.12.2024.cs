using System;

class HataySandıkIçiFanTestGame              //I used AI to compile my idea into code. I decided whats will be questions and possibilities but ai helped me with writing.
{
    static void Main(string[] args)
    {
        Console.WriteLine("Heluu! Welcome to the Hatay Sandık Içi Fan test game. First of alll...");
        Console.Write("Please give me your name: ");
        string playerName = Console.ReadLine();

        Console.WriteLine($"\nHalo (with german sound) {playerName}! Now I will test if you are a true fan of Hatay Sandık Içi :sunglasses: or not!");
        Console.WriteLine("You need to answer with A, B, C, D. Please follow it.\n");

        string answer1 = "", answer2 = "", answer3 = "", answer4 = "", answerAA = "", answerBB = "";

        do
        {
            Console.WriteLine("1. Who is Hatay Sandık Içi?");
            Console.WriteLine("A) Youtuber");
            Console.WriteLine("B) Football player");
            Console.WriteLine("C) Dancer");
            Console.WriteLine("D) Chef");
            Console.Write("Answer: ");
            answer1 = Console.ReadLine().ToUpper();

            if (answer1 != "A" && answer1 != "B" && answer1 != "C" && answer1 != "D")
            {
                Console.WriteLine("Please answer my questions by following the rules. We are doing an important thing right now!");
            }
        } while (answer1 != "A" && answer1 != "B" && answer1 != "C" && answer1 != "D");

        do
        {
            Console.WriteLine("\n2. What is the name of the owner of Hatay Sandık Içi channel?");
            Console.WriteLine("A) Eser Yenenler");
            Console.WriteLine("B) Fırat Sobutay");
            Console.WriteLine("C) Eser Bilen");
            Console.WriteLine("D) Eser Bilmez");
            Console.Write("Answer: ");
            answer2 = Console.ReadLine().ToUpper();

            if (answer2 != "A" && answer2 != "B" && answer2 != "C" && answer2 != "D")
            {
                Console.WriteLine("We are doing an important thing right now! Be serious.");
            }
        } while (answer2 != "A" && answer2 != "B" && answer2 != "C" && answer2 != "D");

        do
        {
            Console.WriteLine("\n3. What type of videos does Hatay Sandık Içi create?");
            Console.WriteLine("A) Football");
            Console.WriteLine("B) Food eating and making");
            Console.WriteLine("C) DIY");
            Console.WriteLine("D) Gameplay");
            Console.Write("Answer: ");
            answer3 = Console.ReadLine().ToUpper();

            if (answer3 != "A" && answer3 != "B" && answer3 != "C" && answer3 != "D")
            {
                Console.WriteLine("Come on man. Please, this is real.");
            }
        } while (answer3 != "A" && answer3 != "B" && answer3 != "C" && answer3 != "D");

        do
        {
            Console.WriteLine("\n4. Does Hatay Sandık Içi have any children?");
            Console.WriteLine("A) Yes");
            Console.WriteLine("B) No");
            Console.Write("Answer: ");
            answer4 = Console.ReadLine().ToUpper();

            if (answer4 != "A" && answer4 != "B")
            {
                Console.WriteLine("You are not taking this seriously. Please answer correctly.");
            }
        } while (answer4 != "A" && answer4 != "B");
        if (answer4 == "A")
        {
            do
            {
                Console.WriteLine("\nAA) Is the child a girl or a boy?");
                Console.WriteLine("A) Girl");
                Console.WriteLine("B) Boy");
                Console.Write("Answer: ");
                answerAA = Console.ReadLine().ToUpper();

                if (answerAA != "A" && answerAA != "B")
                {
                    Console.WriteLine("Please try again.");
                }
            } while (answerAA != "A" && answerAA != "B");
        }
        else if (answer4 == "B") 
        {
            do
            {
                Console.WriteLine("\nBB) Are you sure you are a Hatay Sandık İçi fan?");
                Console.WriteLine("A) No");
                Console.WriteLine("B) Yes");
                Console.Write("Answer: ");
                answerBB = Console.ReadLine().ToUpper();

                if (answerBB != "A" && answerBB != "B")
                {
                    Console.WriteLine("Please answer again.");
                }
            } while (answerBB != "A" && answerBB != "B");
        }

        Console.WriteLine($"\nThanks for playing, {playerName}!");

        Console.WriteLine("\nBased on your answers:");

        if (answer1 == "A")
            Console.WriteLine("Great! You know that Hatay Sandık Içi is a YouTuber.");
        else
            Console.WriteLine("Oops! Hatay Sandık Içi is a YouTuber, not what you guessed!");

        if (answer2 == "C")
            Console.WriteLine("You nailed it! The channel is run by Eser Bilen.");
        else
            Console.WriteLine("Wrong! The channel owner is Eser Bilen.");

        if (answer3 == "B")
            Console.WriteLine("Yummy! You know Hatay Sandık Içi makes food-related videos.");
        else
            Console.WriteLine("Nope! The correct answer is food videos.");

        if (answer4 == "A")
        {
            Console.WriteLine("Correct! He has a daughter named Bade.");
            if (answerAA == "A")
                Console.WriteLine("And yes, she's a girl!");
            else
                Console.WriteLine("Actually, Bade is a girl.");
        }
        else
        {
            Console.WriteLine("Not true! Hatay Sandık Içi does have a daughter named Bade.");
            if (answerBB == "A")
                Console.WriteLine("At least you were honest about not being a fan. ");
            else
                Console.WriteLine("But you still claim to be a fan, so keep learning about him!");
        }

        Console.WriteLine("\nYou always be a fan of Hatay Sandık İçi. Everybody will one day. DW. Thanks for playing See yA");
    }
}
