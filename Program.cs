using System;
using System.Collections.Generic; 

class Program 
{
  static List<string> todo_list = new List<string>();

  static void Main(string[] args)
  {
    bool running = true;
    Console.WriteLine("Welcome to To-Do List Manager");

    while (running)
    {

      Console.WriteLine("\n Select an Option:");
      Console.WriteLine("1: Add a Task");
      Console.WriteLine("2: View Tasks");
      Console.WriteLine("3: Mark Task as Complete");
      Console.WriteLine("4: Delete task");
      Console.WriteLine("5: Exit");

      Console.WriteLine("\n Enter Your Choice: ");
      string Choice = Console.ReadLine();
      switch(Choice)
      {
        case "1":
          AddTask();
          break;
        
        case "2":
          ViewTask();
          break;

        case "3":
          MarkTask();
          break;

        case "4":
          DeleteTask();
          break;

        case "5":
          running = false;
          Console.WriteLine("Exiting.....GoodBye!");
          break;

        default:
          Console.WriteLine("Invalid Choice! Please try Again");
          break;
      }
    }
  }

  static void AddTask()
  {
    Console.WriteLine("Enter task to Add");
    string task = Console.ReadLine();
    todo_list.Add(task);
    Console.WriteLine($"Task {task} has been added successfully!");
  }

  static void ViewTask()
  {
    Console.WriteLine("\n Your To-Do List:");
    if(todo_list.Count == 0)
    {
      Console.WriteLine("No Tasks Available!");
    }
    else
    {
      for(int i = 0; i < todo_list.Count; i++)
      {
        Console.WriteLine($"{i + 1}. {todo_list[i]}");
      }
    }
  }

  static void MarkTask()
  {
    Console.WriteLine("Mention the Number of task to Mark Completed: ");
    ViewTask();
    if(int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= todo_list.Count)
    {
      string completedTask = todo_list[taskNumber - 1];
      todo_list[taskNumber - 1] = "[Completed] " + completedTask;
      Console.WriteLine($"Task {completedTask} has been Marked Complete!!");
    }
    else
    {
      Console.WriteLine("Invalid Task Number!");
    }
  }

  static void DeleteTask()
  {
    Console.WriteLine("Mention the Number of task to be deleted: ");
    ViewTask();
    if(int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= todo_list.Count)
    {
      string removedTask = todo_list[taskNumber - 1];
      todo_list.RemoveAt(taskNumber - 1);
      Console.WriteLine($"Task {removedTask} has been Deleted!");
    }
    else
    {
      Console.WriteLine("Invalid task number!");
    }
  }
}
