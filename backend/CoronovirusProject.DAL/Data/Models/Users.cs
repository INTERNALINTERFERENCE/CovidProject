
namespace CoronovirusProject.DAL.Data.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Sname { get; set; }
        public int IdDepartment { get; set; }

        public virtual Departments IdDepartmentNavigation { get; set; }
    }
}
