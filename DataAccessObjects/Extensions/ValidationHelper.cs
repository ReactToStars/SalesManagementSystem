using System.Text.RegularExpressions;

namespace DataAccessObjects.Extensions
{
	public class ValidationHelper
	{
		public static bool IsNullOrWhiteSpace(params string[] value)
		{
			foreach (var item in value)
			{
				if (string.IsNullOrWhiteSpace(item))
				{
					return true;
				}
			}

			return false;
		}

		public static bool IsValidEmail(string email)
		{
			// Define a regular expression for basic email validation
			string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
			return IsValid(pattern, email);
		}

		public static bool IsValidPassword(string password)
		{
			//Minimum eight characters, at least one uppercase letter, one lowercase letter and one number
			string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$";
			return IsValid(pattern, password);
		}

		public static bool IsValidText(params string[] value)
		{
			string pattern = @"^[a-zA-Z\s]*$";
			foreach (var item in value)
			{
				if (!IsValid(pattern, item))
				{
					return false;
				}
			}
			return true;
		}

		public static bool IsValid(string pattern, string value)
		{
			Regex regex = new Regex(pattern);
			return regex.IsMatch(value);
		}
	}
}
