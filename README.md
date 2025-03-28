⭐ My C# While Loop Coding Tasks

Welcome to my GitHub repository! Here, you'll find various C# coding tasks with structured numbering and detailed solutions. 💻✨

🐜 Introduction

This repository contains small but essential C# programs that focus on fundamental concepts like loops, conditionals, and input/output handling. Each task is numbered and documented for easy reference.

📎 Folder Structure

/While-Loops-Tasks
│—— /Task1_PrintNumbersWhileLoop
│    ├—— PrintNumbersWhileLoop.cs
│—— /Task2_ReadOddNumber
│    ├—— ReadOddNumber.cs
│—— README.md

Each task is stored in a separate folder named according to its purpose. The .cs files contain the C# source code for each task.

🛠️ Setup & Usage

🔧 Prerequisites

    Install .NET SDK (if not already installed)
    Use any C#-compatible editor (e.g., Visual Studio, VS Code)

▶️ Running a Task

    Open a terminal or command prompt.
    Navigate to the task directory:

    cd Task1_PrintNumbersWhileLoop

Compile the program:

    dotnet build

Run the executable:

    dotnet run

    Enter input when prompted, and see the output in the console!

📌 Task List

1️⃣ Print Numbers (While Loop) 🔄

Namespace: _1_PrintNumbersWhileLoop
📌 Description:
Prints numbers from 1 to 100 using a while loop.

📝 Code:
```csharp
namespace _1_PrintNumbersWhileLoop
{
    internal class PrintNumbersWhileLoop
    {
        static void Main(string[] args)
        {
            int num = 1;

            while (num <= 100)
            {
                Console.WriteLine(num);
                num++;
            }
        }
    }
}
```

2️⃣ Read Odd Number 🔢

Namespace: _2_ReadOddNumber
📌 Description:
Reads an integer from the console. If the number is even, it keeps asking until an odd number is entered.

📝 Code:
```csharp
namespace _2_ReadOddNumber
{
    internal class ReadOddNumber
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            while (num % 2 == 0)
            {
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(num);
        }
    }
}
```

🎯 Commit Progress Tracker

🚀 Goal: 500 commits in 2025
📅 Current Progress: 337 commits

📊 Progress Bar:

███████████████████▒▒▒▒▒▒ 67.4% (337/500)

📌 Milestones:
✅ 100 commits
✅ 200 commits
✅ 300 commits
🔲 400 commits
🔲 500 commits (🎉)

