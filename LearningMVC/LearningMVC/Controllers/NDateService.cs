namespace LearningMVC.Controllers
{
    public class NDateService : IDateService
    {
        public string GetDate()
        {
            return DateTime.Now.AddYears(53).ToString();
        }
    }
}
