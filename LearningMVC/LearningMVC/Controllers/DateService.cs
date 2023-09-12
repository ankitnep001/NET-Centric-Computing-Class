namespace LearningMVC.Controllers
{
    public class DateService : IDateService
    {
        public string GetDate()
        {
            return DateTime.Now.ToString();
        }
    }
}
