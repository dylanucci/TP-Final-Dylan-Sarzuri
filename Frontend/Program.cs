using Frontend.Client;
using Frontend.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace Frontend
{
    internal static class Program
    {

        //public ProductoDTO Producto { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var serviceCollection = new ServiceCollection();
                
           AddServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var principal = serviceProvider.GetRequiredService<Principal>();

            Application.Run(principal);
        }

        public static void AddServices(IServiceCollection Services)
        {
            string backendUrl = "http://localhost:5033";

            Services.AddHttpClient("Backend", http =>
            {
                http.BaseAddress = new Uri(backendUrl);
            });

            Services.AddScoped(sp =>
            {
                var http = sp.GetRequiredService<IHttpClientFactory>().CreateClient("Backend");
                return new ApiClient(http);
            });



            Services.AddSingleton<Principal>()
                .AddScoped<Register>()
                .AddTransient<ClienteUI>()
                .AddTransient<AdminUI>()
                .AddTransient<LoginOrRegisterUI>()
                .AddTransient<Login>()
                .AddTransient<LoginOrRegisterUI>()
                .AddTransient<ClienteCompraUI>()
                .AddTransient<ConfigCliente>()
                .AddTransient<ClientesTable>()
                .AddTransient<ProductosTable>()
                .AddTransient<ComprasUI>()
                .AddTransient<AdminComprasUI>()
                .AddTransient<AgregarProductoUI>();

        }

    }
}