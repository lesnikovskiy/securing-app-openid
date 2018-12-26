using IdentityServer4.Models;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace Marvin.IDP
{
	public static class Config
	{
		public static List<TestUser> GetUsers()
		{
			return new List<TestUser>
			{
				new TestUser
				{
					SubjectId = "4afc0ebb-710d-4ce0-b95e-0273aec76fad",
					Username = "Frank",
					Password = "pass",
					Claims = new List<Claim>
					{
						new Claim("given_name", "Frank"),
						new Claim("family_name", "Underwood")
					}
				},
				new TestUser
				{
					SubjectId = "6d22f716-1fc1-4cef-987f-1abc0b97fc97",
					Username = "Ruslan",
					Password = "pass",
					Claims = new List<Claim>
					{
						new Claim("given_name", "Ruslan"),
						new Claim("family_name", "Lesnikovskiy")
					}
				},
				new TestUser
				{
					SubjectId = "4af30fcf-dcfb-4394-b6e7-bae7f17ed3b4",
					Username = "Julia",
					Password = "pass",
					Claims = new List<Claim>
					{
						new Claim("given_name", "Julia"),
						new Claim("family_name", "Vakulyuk")
					}
				}
			};
		}

		public static IEnumerable<IdentityResource> GetIdentityResources()
		{
			return new List<IdentityResource>
			{
				new IdentityResources.OpenId(),
				new IdentityResources.Profile()
			};
		}

		public static IEnumerable<Client> GetClients()
		{
			return new List<Client>
			{

			};
		}
	}
}