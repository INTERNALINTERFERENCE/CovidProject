
namespace CoronovirusProject.DAL.Data.Models
{
    public class DepartmentView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public static implicit operator DepartmentView(Departments departments)
        {
            if (departments == null) { return new DepartmentView(); }

            return new DepartmentView { Id = departments.Id, Name = departments.Name };
           
        }
    }
}
