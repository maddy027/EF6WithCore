using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BL
{
    public class GetStudentDetails
    {
		public IList<Entities.Student> GetStudDetails()
		{
			return new DAL.EpackContext().GetStudentDetails().ToList();
		}
	}
}
