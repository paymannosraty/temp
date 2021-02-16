using System;

namespace Models.Base
{
	public class BaseEntity : object
	{
		public BaseEntity() : base()
		{
			Id = Guid.NewGuid();
		}

		public Guid Id { get; set; }
	}
}
