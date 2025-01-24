using Microsoft.AspNetCore.Mvc;
using SampleAPI.model;
namespace SampleAPI.Controllers
{
    [Route("/api")]
    [ApiController]
    public class ToDoController: ControllerBase
    {
        [HttpGet]
        public List<ToDo> GetAllTodo()
        {
            return SampleAPI.repositories.ToDoRepo.Repo;
        }

        [HttpPost]
        public string PostTodo()
        {
            ToDo x = SampleAPI.repositories.ToDoRepo.Repo.Last();
            int y = Int32.Parse(x.Id);
            ToDo z = new ToDo((y + 1).ToString(), "SH", $"Description {y + 1}");
            SampleAPI.repositories.ToDoRepo.Repo.Add(z);
            return "Success";
        }

        //[HttpDelete]
        //public string DeleteToDo(string Id)
        //{
        //    //SampleAPI.repositories.ToDoRepo.Repo.Remove()

        //}
    }

}
