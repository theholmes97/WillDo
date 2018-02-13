using System;
using WillDo.Repository.Models;

namespace WillDo.ViewModels
{
    public class GoalDetailViewModel : BaseViewModel
    {
        public Goal Goal { get; set; }
        public GoalDetailViewModel(Goal item = null)
        {
            Title = item?.Title;
            Goal = item;
        }
    }
}
