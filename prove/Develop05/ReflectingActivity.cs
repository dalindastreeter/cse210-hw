using System;
using System.Diagnostics;

namespace Develop05;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;


     public ReflectingActivity() : base(
         "Reflecting Activity", 
         "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n",
         30)
     { 
        _prompts = new List<string>();
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions = new List<string>();
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
     }

     public void Run()
     {
         DisplayPrompt();
         Console.Write("Now ponder on each of the following questions as they related to this experience.\nYou may begin in:");
         Console.WriteLine("\n");
         ShowCountDown(5);
         Console.Clear();
         DisplayQuestions();
     }

     public string GetRandomPrompt()
     {
         Random random = new Random();
         int randomInt = random.Next(_prompts.Count);
         return _prompts[randomInt];
     }

     public string GetRandomQuestion()
     {
         Random random = new Random();
         int randomInt = random.Next(_questions.Count);
         return _questions[randomInt];
     }


     public void DisplayPrompt()
     {
         Console.WriteLine("Consider the following prompt:\n");
         string prompt = GetRandomPrompt();
         Console.WriteLine($"--- {prompt} ---\n");
         Console.WriteLine("When you have something in mind,press enter to continue.");
         Console.ReadLine();
     }
 
     public void DisplayQuestions()
     {
         int period = 5;
         int time = 0;
         while (true)
         {
             string question = GetRandomQuestion();
             Console.Write($"> {question}");
             ShowSpinner(period);
             Console.Write("\n");
             time += period;
             if (time >= _duration)
             {
                 break;
             }
         }
     }

}


