namespace YotiApi.Helpers;

public static class ExtensionClientFactory
{
	public static void AddYotiHttpClient(this IServiceCollection serviceCollection, IConfigurationSection configurationSection)
	{
		serviceCollection.AddHttpClient("yoti", client =>
		{
			client.BaseAddress = new Uri("https://api.yoti.com/idverify/v1", UriKind.Absolute);
		});
	}
}
