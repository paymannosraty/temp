using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
	public class Contact : Base.BaseEntity
	{
		public Contact() : base()
		{
		}

		/**********/
		public Guid CustomerCode { get; set; }
		/**********/

		/**********/
		public Guid OwnerId { get; set; }
		/**********/

		/**********/
		[MaxLength(30)]
		public string FirstName { get; set; }
		/**********/

		/**********/
		[MaxLength(30)]
		public string LastName { get; set; }
		/**********/

		/**********/
		[MaxLength(30)]
		public string CompanyName { get; set; }
		/**********/

		/**********/
		public Guid CompanyId { get; set; }
		/**********/

		/**********/
		[StringLength(maximumLength: 11, MinimumLength = 11)]
		public string MobilePhone { get; set; }
		/**********/

		/**********/
		[RegularExpression(pattern: @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
		public string EmailAddress { get; set; }
		/**********/

		/**********/
		[StringLength(maximumLength: 11, MinimumLength = 11)]
		public string WorkPhone { get; set; }
		/**********/

		/**********/
		public List<Guid> SegmentIds { get; set; }
		/**********/

		/**********/
		public Fields Fields { get; set; }
		/**********/
	}
}
