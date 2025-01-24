using SampleAPI.model;
namespace SampleAPI.repositories
{
    public class ToDoRepo
    {
        public static List<ToDo> Repo = new List<ToDo>(){
            new ToDo("12","Ad","Desc1"),
            new ToDo("13","IT","Desc2"),
            new ToDo("14","YA","Desc3"),
        };

        public ToDoRepo() { }

    }
}
