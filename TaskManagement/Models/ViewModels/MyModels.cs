using System.Collections.Generic;

namespace TaskManagement.Models.ViewModels
{
    public class MyModels
    {
        public IEnumerable<TaskManagement.Models.ViewModels.RecordsViewModel> RecordsViewModel { get; set; }
        public TaskManagement.Models.ViewModels.RecordsViewModel Records { get; set; }
    }
}
