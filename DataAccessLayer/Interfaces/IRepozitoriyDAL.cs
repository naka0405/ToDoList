using DataAccessLayer.Models;
using System.Collections.Generic;
using Task = DataAccessLayer.Models.Task;

namespace DataAccessLayer.Interfaces
{
    public interface IRepozitoriyDAL
    {
        List<Task> GetAllTasks();
        List<DoneTask> GetAllDoneTasks();
        List<Task> GetTasksByCategoryId(int id);
        void AddTask(Task task);
        void ToDoTaskByTaskId(int id);
        void RemoveTaskById(int id);
        void ToDoTaskByTrigger(int id);
    }
}
