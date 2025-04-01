⭐ My C# While Loop Coding Tasks

Welcome to my GitHub repository! Here, you'll find various C# coding tasks with structured numbering and detailed solutions. 💻✨

🐜 Introduction

This repository contains small but essential C# programs that focus on fundamental concepts like loops, conditionals, and input/output handling. Each task is numbered and documented for easy reference.

📎 Folder Structure

/While-Loops-Tasks
│—— /Task1_Numbers-One-To-One-Hundred
│    ├—— Numbers-One-To-One-Hundred.cs
│—— /Task2_DecreasingNumbers
│    ├—— DecreasingNumbers.cs
│—— /Task3_Sequence
│    ├—— Sequence.cs
│—— /Task4_SumDigits
│    ├—— SumDigits.cs
│—— README.md

Each task is stored in a separate folder named according to its purpose. The .cs files contain the C# source code for each task.

🛠️ Setup & Usage

🔧 Prerequisites

    Install .NET SDK (if not already installed)
    Use any C#-compatible editor (e.g., Visual Studio, VS Code)

▶️ Running a Task

    Open a terminal or command prompt.
    Navigate to the task directory:

    cd Task1_Numbers-One-To-One-Hundred

Compile the program:

    dotnet build

Run the executable:

    dotnet run

    Enter input when prompted, and see the output in the console!

📌 Task List

1️⃣ Numbers One to One Hundred 🔄

Namespace: _1_Numbers-One-To-One-Hundred
📌 Description:
Prints numbers from 1 to 100 using a while loop.

📝 Code:
```csharp
namespace _1_Numbers-One-To-One-Hundred
{
    internal class NumbersOneToOneHundred
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

2️⃣ Decreasing Numbers 🔢

Namespace: _2_DecreasingNumbers
📌 Description:
Reads an integer from the console. If the number is even, it keeps asking until an odd number is entered.

📝 Code:
```csharp
namespace _2_DecreasingNumbers
{
    internal class DecreasingNumbers
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

3️⃣ Sequence 🔢

Namespace: _3_Sequence
📌 Description:
Reads an integer and prints a sequence where each number follows the pattern: `k = k * 2 + 1` until it exceeds the input value.

📝 Code:
```csharp
namespace _3_Sequence
{
    internal class Sequence
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());
            int k = 1;

            while (k <= maxNumber)
            {
                Console.WriteLine(k);
                k = k * 2 + 1;
            }
        }
    }
}
```

4️⃣ Sum Digits ➕

Namespace: _4_SumDigits
📌 Description:
Reads an integer and sums its digits.

📝 Code:
```csharp
namespace _4_SumDigits
{
    internal class SumDigits
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                sum += lastDigit;
                number /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
```

🎯 Commit Progress Tracker

🚀 Goal: 500 commits in 2025
📅 Current Progress: 344 commits

📊 Progress Bar:

████████████████████▒▒▒▒▒ 68.8% (344/500)

📌 Milestones:
✅ 100 commits
✅ 200 commits
✅ 300 commits
🔲 400 commits
🔲 500 commits (🎉)

