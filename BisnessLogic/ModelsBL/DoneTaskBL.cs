using System.Collections.Generic;

namespace BisnessLogic.ModelsBL
{
    public class DoneTaskBL
    {
        public DoneTaskBL()
        {
            CategoryProperty = new List<CategoryBL>();
        }
        public int ID { get; set; }
        public string DoneTaskName { get; set; }
        public string FinishDate { get; set; }
        // public Category CategoryId { get; set; }
        public List<CategoryBL> CategoryProperty { get; set; }
    }
}
