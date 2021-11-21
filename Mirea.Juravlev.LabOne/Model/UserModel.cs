using System.Text.RegularExpressions;

namespace Mirea.Juravlev.LabOne
{
	public class UserModel
	{
		public const int RequiredPasswordLength = 6;
		public static readonly Regex Simbols = new Regex(@"[A-z]");
		public static readonly string SimbolsInfo = "только латинские символы";

		/// <summary>ID или имя пользователя</summary>
		public string Id { get; set; } = string.Empty;
		/// <summary>Пароль</summary>
		public string Password { get; set; } = string.Empty;
		/// <summary>ФИО</summary>
		public string Represenative { get; set; } = string.Empty;
		/// <summary>Дата рождения</summary>
		public DateTime Birthdate { get; set; }
		/// <summary>Место рождения</summary>
		public string Place { get; set; } = string.Empty;
		/// <summary>Номер телефона</summary>
		public string PhoneNumber { get; set; } = string.Empty;
	}
}
