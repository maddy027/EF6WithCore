using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DAL
{
    public class EpackContext
    {
		public IEnumerable<Entities.Student> GetStudentDetails()
		{
			IList<Entities.Student> lstStudent = new List<Entities.Student>();
			try
			{

				using (Mar2018Entities db = new Mar2018Entities())
				{


					var result = db.GetStudentDetails();
					foreach (var v in result)
					{
						lstStudent.Add(new Entities.Student() { Name = v.name, Id = v.StudentId });
					}

				}
			}
			catch (Exception ex)
			{

			}
			//lstStudent.Add(new Entities_.Student() { Name = "Mahadev", Id = 1 });
			return lstStudent;
		}
	}
}
