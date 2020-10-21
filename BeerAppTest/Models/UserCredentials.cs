using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BeerAppTest.Models
{
    public class UserCredentials
    {
		[Key]
		[ForeignKey("User")]
		public int UserID { get; set; }

		public string UserName { get; set; }


		[DataType(DataType.EmailAddress)]
		public string EmailAdress { get; set; }


		[DataType(DataType.Password)]
		public string Password { get; set; }


		public virtual User User { get; set; }
	}
}