using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "What was the best part of your day?",
        "What made you smile today?",
        "What challenged you today?",
        "What are you grateful for?",
        "What goal are you working toward?",
        "What did you learn today?",
        "What is something you want to improve?",
        "Who inspired you today?",
        "What is stressing you out right now?",
        "What are you excited about?",
        "What is something positive that happened today?",
        "What motivates you?",
        "What is your biggest dream?",
        "What made today unique?",
        "How are you feeling emotionally today?",
        "What is one thing you wish people understood about you?",
        "What are your priorities right now?",
        "What memory stands out today?",
        "What is something you overcame today?",
        "What would make tomorrow better?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}