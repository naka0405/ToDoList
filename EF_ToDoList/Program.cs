using BisnessLogic;
using BisnessLogic.ModelsBL;
using System;


namespace EF_ToDoList
{
    class Program
    {
        //С использованием подхода Code First реализовать доступ к данным для предметной области TODO-list.
        //В нем определены следующие сущности: Задача, Категория, Выполненные задачи.Каждая задача может относиться
        //    к нескольким категориям. По завершению работы над задачей она помещается в таблицу «Выполненные задачи».
        static void Main(string[] args)
        {
            var manager = new ToDoListManager();
            //var listTaskBL = manager.GetAllTasks();
            //foreach(var task in listTaskBL)
            //{
            //    Console.WriteLine($"{task.ID}-{task.TaskName}: {task.StartDate}");
            //}
            //var listTasks=manager.GetTasksByCategoryId(1);            
            //foreach (var tsk in listTasks)
            //{               
            //    Console.WriteLine($"{tsk.ID}-{tsk.TaskName}|");
            //}
            var newTask = new TaskBL() { TaskName = "wash the window", StartDate = DateTime.Now.ToString(), DoneStatus=false };
            //manager.AddTask(newTask);
            // manager.ToDoTaskByTaskId(5);
            manager.ToDoTaskByTrigger(11);
        }
    }
}
