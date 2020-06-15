using BisnessLogic.Interfaces_BL;
using BisnessLogic.ModelsBL;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using DataAccessLayer.Repozitories;
using System;
using System.Collections.Generic;


namespace BisnessLogic
{
    public class ToDoListManager : IBisnessLogic
    {
        private IRepozitoriyDAL repozitoriyDAL;
        public ToDoListManager()
        {
            repozitoriyDAL = new RepozitoriyDAL();
        }
        public void AddTask(TaskBL taskBL)
        {
            var task = new Task() { TaskName = taskBL.TaskName, StartDate = taskBL.StartDate, StatusDone=false };
           repozitoriyDAL.AddTask(task);
        }

        public List<DoneTaskBL> GetAllDoneTasks()
        {
            throw new NotImplementedException();
        }

        public List<TaskBL> GetAllTasks()
        {
           
            var listBL = new List<TaskBL>();
            var list = repozitoriyDAL.GetAllTasks();
            foreach(var t in list)
            {
                var taskBL = new TaskBL()
                {
                    ID = t.ID,
                    TaskName = t.TaskName,
                    StartDate = t.StartDate
                };
                listBL.Add(taskBL);
            }
            return listBL;
        }


        public List<TaskBL> GetTasksByCategoryId(int id)
        {
            var listTaskBL = new List<TaskBL>();
            var listTask = repozitoriyDAL.GetTasksByCategoryId(id);
            foreach (var t in listTask)
            {
                var newTaskBL = new TaskBL()
                {
                    ID = t.ID,
                    TaskName = t.TaskName,
                    StartDate = t.StartDate,
                    DoneStatus=t.StatusDone
                };
                listTaskBL.Add(newTaskBL);
            }
            return listTaskBL;
        }

        public void RemoveTaskById(int id)
        {
            repozitoriyDAL.RemoveTaskById(id);
        }

        public void ToDoTaskByTaskId(int id)
        {
            repozitoriyDAL.ToDoTaskByTaskId(id);
        }

        public void ToDoTaskByTrigger(int id)
        {
            repozitoriyDAL.ToDoTaskByTrigger(id);
        }
    }
}
