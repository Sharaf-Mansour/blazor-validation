using System.Collections.Generic;

namespace FluentValidationSample.Models
{
	public class Person
	{
		public string Salutation { get; set; }
		public string GivenName { get; set; }
		public string MiddleNames { get; set; }
		public string FamilyName { get; set; }
		public string EmailAddress { get; set; }
		public NamedAddress Addresses { get; set; }

		public Person()
		{
			Addresses = 	new NamedAddress
				{
					Name = "Duplicated address - Home"
				};
		}
	}
}
