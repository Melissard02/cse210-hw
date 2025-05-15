using System.Collections.Generic;
using System;

class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }

    private List<string> _prompts = new List<string> {"Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be? What was the best part of your day?",
        "What was the most memorable part of your day?",
        "What challenged you today, and how did you respond?",
        "How did you make progress—personally, academically, or professionally?",
        "Describe a moment when you felt proud of yourself today.",
        "What would you do differently if you could redo today?",
        "What's one lesson you learned today?",
        "What habit are you trying to build, and how did you work toward it today?",
        "What did you do today that aligns with your long-term goals?",
        "What's something you're currently working on improving in yourself?",
        "Describe a recent setback and what it taught you.",
        "What are three things you're grateful for today?",
        "Who made a positive impact on you today, and why?",
        "What made you smile today?",
        "Describe a simple pleasure you enjoyed today.",
        "What are you looking forward to tomorrow?",
        "What emotion dominated your day, and what do you think caused it?",
        "When did you feel most energized or focused today?",
        "Did anything make you feel stressed or overwhelmed today? Why?",
        "How do you typically handle difficult emotions—and how did that play out today?",
        "What did you do for your mental or physical well-being today?",
        "What was the most interesting thing you learned today?",
        "What task or subject did you find most challenging today?",
        "How did you stay productive or organized today?",
        "What's one question you still have from today's lessons or work?",
        "How do you plan to apply what you learned today?",
        "If today had a title, what would it be?",
        "What's one idea or topic that sparked your curiosity today?",
        "If you could summarize today in a single sentence, what would it say?",
        "Describe how you handled a difficult situation today.",
        "What's something you'd like to tell your future self about today?"};

    public void RandomPrompt()
    {
        Random r = new Random();
        Prompt = _prompts[r.Next(_prompts.Count)];
        //return prompts[prompt];
    }



    public void GetResponse()
    {
        Console.WriteLine(Prompt);
        Console.Write(">");
        Response = Console.ReadLine();

    }


    public void DateStamp()
    {
        Date = DateTime.Now;
        //string date = now.ToString();
    }

    public void CreateEntry()
    {
        RandomPrompt();
        GetResponse();
        DateStamp();
        //string entry = $"{date} {prompt}: {response}";
    }

    public override string ToString()
    {
        return $"{Date.ToShortDateString()} - {Prompt}\n{Response}";
    }

}