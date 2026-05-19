using System;

class Program
{
    static void Main(string[] args)
    {
        // Extra credit: I added 20 random prompts instead of only a few.
        // Extra credit: I save and load entries using a separator so multiple entries can be stored in one file.

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("==== Journal Program ====");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. View all journal entries");
            Console.WriteLine("3. Load journal entries from file");
            Console.WriteLine("4. Save journal entries to file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Entry entry = new Entry(prompt, response);
                journal.AddEntry(entry);

                Console.WriteLine("Journal entry saved!");
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to load from: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to save to: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}