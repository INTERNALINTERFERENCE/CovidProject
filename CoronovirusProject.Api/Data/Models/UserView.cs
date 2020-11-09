using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronovirusProject.Api.Data.Models
{
    public class UserView
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Sname { get; set; }
        public virtual DepartmentView Department { get; set; }

        public static implicit operator UserView(Users users)
        {
            if(users == null) { return new UserView(); }

            return new UserView { Id = users.Id, Fname = users.Fname,
                        Sname = users.Sname, Department = users.IdDepartmentNavigation};
        }
    }
}
