namespace PleaseSign.Extensions
{
	public static class ServiceCollectionsExtensions
	{
		public static void AddPleaseSignHttpClient(this IServiceCollection serviceCollection, IConfigurationSection options)
		{
			serviceCollection.AddHttpClient("pleasesign", client =>
			{
				client.BaseAddress = new Uri("https://public.pleasesign.eu", UriKind.Absolute);
				client.DefaultRequestHeaders.Add("X-PLEASESIGN-KEY", options.GetValue<string>("Key"));
				client.DefaultRequestHeaders.Add("X-PLEASESIGN-SECRET", options.GetValue<string>("SecretKey"));
			});
		}
	}
}
