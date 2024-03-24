using DataAccessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagementWinApp.Authentications
{
	public class CustomIdentity : IIdentity
	{
		public CustomIdentity(CurrentUser currentUser)
		{
			if (currentUser == null)
			{
				throw new ArgumentNullException(nameof(currentUser));
			}

			// Map your properties to the identity properties as needed
			Id = currentUser.Id;
			Email = currentUser.Email;
			Name = currentUser.Name;
			Password = currentUser.Password;
			Role = currentUser.Role;
			AuthenticationType = "CustomAuthentication"; // You can set a custom authentication type if needed
			IsAuthenticated = true; // Set to true if the user is authenticated, false otherwise
		}

		public string AuthenticationType { get; private set; }
		public bool IsAuthenticated { get; private set; }
		public int? Id { get; private set; }
		public string? Email { get; private set; }
		public string? Name { get; private set; }
		public string? Password { get; private set; }
		public string? Role { get; private set; }
	}
}
