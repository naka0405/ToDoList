using DataAccessLayer.Models;
using System.Collections.Generic;
using System.Data.Entity;


namespace DataAccessLayer
{
    public class Initializer :DropCreateDatabaseIfModelChanges<ToDoListContext>
    {
            protected override void Seed(ToDoListContext ctx)
            {
            var homeCtg = new Category() { CategoryName = "HomeCtg" };
            var workCtg = new Category() { CategoryName = "WorkCtg" };
            var morningCtg= new Category() { CategoryName = "MorningCtg" };

            var task1 = new Task() { TaskName = "payBills", StartDate = "13.06.20", StatusDone=false };
            var task2 = new Task() { TaskName = "washDishes", StartDate = "13.06.20" , StatusDone = false };
            var task3 = new Task() { TaskName = "printContract", StartDate = "13.06.20", StatusDone = false };

            homeCtg.TaskProp.Add(task2);
            workCtg.TaskProp.Add(task3);
            morningCtg.TaskProp.AddRange(new List<Task> { task1, task3 });

            task1.CatigoryProp.Add(workCtg);
            task3.CatigoryProp.Add(homeCtg);

            ctx.Tasks.AddRange(new List<Task> { task1, task2, task3 });
            ctx.Categories.AddRange(new List<Category> { homeCtg, workCtg, morningCtg });
            

            ctx.SaveChanges();
                base.Seed(ctx);
            }
        }
    }

