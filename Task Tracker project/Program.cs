namespace Task_Tracker_project
{
    internal class Program
    {
        static string[] taskes = new string[100];
        static int taskIndex = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To My Task Tracker project");
            Console.WriteLine("-----------------------------------");

            while (true)
            {
                Console.WriteLine("enter number from 1 to 5");
                Console.WriteLine(" 1 Add");
                Console.WriteLine(" 2 View");
                Console.WriteLine(" 3 Complete");
                Console.WriteLine(" 4 Remove");
                Console.WriteLine(" 5 Exit");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ViewTasks();
                        break;
                    case "3":
                        MarkComplete();
                        break;
                    case "4":
                        DeleteTask();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("please enter number from 1 to 5");
                        break;
                }
            }

        }

        private static void AddTask()
        {
            Console.WriteLine("Enter Task Title");
            string taskTitle = Console.ReadLine();
            taskes[taskIndex] = taskTitle;
            Console.WriteLine("Task added");
            taskIndex++;
        }

        private static void ViewTasks()
        {
            Console.WriteLine("Task List : ");

            for (int i = 0; i < taskIndex; i++)
            {
                Console.WriteLine($"{i + 1} Task List : {taskes[i]}");
            }
        }

        private static void MarkComplete()
        {
            Console.WriteLine("enter task number ");
            string taskNumber = Console.ReadLine();
            int TaskId = Convert.ToInt32(taskNumber);
            taskes[TaskId] = taskes[TaskId] + "Complited";
        }

        private static void DeleteTask()
        {
            Console.WriteLine("enter task number to delete");
            string taskNumber = Console.ReadLine();
            int TaskId = Convert.ToInt32(taskNumber);
            taskes[TaskId] = string.Empty;
        }
    }
}
