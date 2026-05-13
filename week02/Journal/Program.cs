using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> entries = new List<string>();

        // List of journal prompts
        List<string> prompts = new List<string>()
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

        Random random = new Random();

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

            // Write Entry
            if (choice == "1")
            {
                Console.Clear();

                // Pick random prompt
                int randomIndex = random.Next(prompts.Count);
                string prompt = prompts[randomIndex];

                Console.WriteLine("Journal Prompt: ");
                Console.WriteLine(prompt);
                Console.WriteLine();

                Console.Write("Your response: ");
                string response = Console.ReadLine();

                // Current date and time
                string CurrentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // Create new journal entry and add to list
                string entry =
                    $"Date: {CurrentDateTime}\n" +
                    $"Prompt: {prompt}\n" +
                    $"Response: {response}\n";

                // save entry to list
                entries.Add(entry);

                Console.WriteLine();
                Console.WriteLine("Journal entry saved!");
            }
            else if (choice == "2")
            {
                Console.Clear();

                Console.WriteLine("==== Journal Entries ====");
                if (entries.Count == 0)
                {
                    Console.WriteLine("No journal entries found.");
                }
                else
                {
                    foreach (string entry in entries)
                    {
                        Console.WriteLine(entry);
                        Console.WriteLine("-------------------------");
                        Console.WriteLine(entry);
                    }
                }
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to load from: ");
                string filename = Console.ReadLine();

                if (File.Exists(filename))
                {
                    string fileContent = File.ReadAllText(filename);
                    string[] loadedEntries = fileContent.Split("~~ENTRY~~");

                    entries.Clear();

                    foreach (string entry in loadedEntries)
                    {
                        if (entry.Trim() != "")
                        {
                            entries.Add(entry.Trim());
                        }
                    }
                    Console.WriteLine("Journal entries loaded successfully!");
                }
                else
                {
                    Console.WriteLine("File not found.");
                }
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to save to: ");
                string filename = Console.ReadLine();

                string fileContent = string.Join("~~ENTRY~~", entries);
                File.WriteAllText(filename, fileContent);

                Console.WriteLine("Journal entries saved successfully!");
            }
            else if (choice == "5")
            {
                running = false;
                Console.WriteLine("Exiting program. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}