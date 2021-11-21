using Blazored.LocalStorage;

namespace Mirea.Juravlev.LabOne
{
	public class UserStorage
	{
		private readonly ILocalStorageService _storageService;
		public UserStorage(ILocalStorageService storageService)
		{
			_storageService = storageService;
		}
		public async ValueTask<UserModel> GetUser(string id)
		{
			var user = await _storageService.GetItemAsync<UserModel>(id, default);
			return user ?? new UserModel();
		}

		public ValueTask SaveUser(UserModel user)
			=> _storageService.SetItemAsync(user.Id, user, default);

	}
}
