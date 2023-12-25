using System;
using System.Security.Cryptography;
using System.Text;

public class SecretKeyGenerator
{
	public static string GenerateRandomSecretKey(int length)
	{
		const string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
		var random = new Random();
		var result = new StringBuilder(length);

		for (int i = 0; i < length; i++)
		{
			result.Append(validChars[random.Next(validChars.Length)]);
		}

		return result.ToString();
	}

	public static void Main(string[] args)
	{
		string secretKey = GenerateRandomSecretKey(32); // Generate a 32-character secret key
		Console.WriteLine($"Generated Secret Key: {secretKey}");
	}
}



//namespace SuperInsuranceAPI.Keys
//{
//	public class SecretKeyGenerator
//	{
//	}
//}
