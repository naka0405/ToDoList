using BisnessLogic.ModelsBL;
using System.Collections.Generic;


namespace BisnessLogic.Interfaces_BL
{
    public interface IBisnessLogic
    {
        List<TaskBL> GetAllTasks();
        List<DoneTaskBL> GetAllDoneTasks();
        List<TaskBL> GetTasksByCategoryId(int id);
        void AddTask(TaskBL task);
       void ToDoTaskByTaskId(int id);
        void RemoveTaskById(int id);
        void ToDoTaskByTrigger(int id);
    }
}
