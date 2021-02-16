using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
	public class Person : object
	{
		public Person() : base()
		{
		}

		public Contact Contact { get; set; }
	}
}
