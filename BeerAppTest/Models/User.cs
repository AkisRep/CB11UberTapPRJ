using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeerAppTest.Models
{
    public class User
    {
        public int ID { get; set; }
		public Location Location { get; set; }

		public Gender Gender { get; set; }

		public string LastName { get; set; }

		public string FirstName { get; set; }

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		[Display(Name = "Birth Day")]
		public DateTime BirtDate { get; set; }

		public string FullName  // calculated property
		{
			get
			{
				return FirstName + " " + LastName;
			}
		}

        public virtual UserCredentials UserCredentials { get; set; }
    }
}