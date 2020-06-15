using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Task = DataAccessLayer.Models.Task;
using System.Data.Entity;

namespace DataAccessLayer.Repozitories
{
    public class RepozitoriyDAL : IRepozitoriyDAL
    {
        private ToDoListContext ctx;
        public RepozitoriyDAL()
        {
            ctx = new ToDoListContext();
        }
        public void AddTask(Task task)
        {
            using (ctx)
            {
                ctx.Tasks.Add(task);
                ctx.SaveChanges();
            }
                
        }

        public List<DoneTask> GetAllDoneTasks()
        {
            throw new NotImplementedException();
        }

        public List<Task> GetAllTasks()
        {
            using (ctx)
            {
                var list = ctx.Tasks.ToList();
                return list;
            }
                          
        }

        public List<Task> GetTasksByCategoryId(int id)
        {
            using (ctx)
            {
                var category = ctx.Categories.Include(t=>t.TaskProp).Where(x=>x.ID==id).FirstOrDefault();
                Console.WriteLine($"{category.CategoryName.ToUpper()}");
                var tasks = category.TaskProp.ToList();               
               
                return tasks;
            }               
        }

        public void RemoveTaskById(int id)
        {
            using (ctx)
            {
                var task=ctx.Tasks.Where(x => x.ID == id).FirstOrDefault();
                ctx.Tasks.Remove(task);
                ctx.SaveChanges();
            }
                
        }

        public void ToDoTaskByTaskId(int id)
        {
            using (ctx)
            {
                var task = ctx.Tasks.Where(x => x.ID == id).FirstOrDefault();
                var doneTask = new DoneTask()
                {
                    DoneTaskName = task.TaskName,
                    FinishDate = DateTime.Now.ToString()
                };
                task.StatusDone = true;
                //ctx.Tasks.Remove(task);
                ctx.DoneTasks.Add(doneTask);
                ctx.SaveChanges();
            }
        }

        public void ToDoTaskByTrigger(int id)
        {
            using (ctx)
            {
                var task = ctx.Tasks.Where(x => x.ID == id).FirstOrDefault();
               
                task.StatusDone = true;                
                ctx.SaveChanges();
            }
        }
    }
}
