using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interfaces.CRUD;
using Application.Interfaces.UseCases;
using Application.UseCases.Administrador;
using Application.UseCases.Cliente;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Application.Mappers;


namespace Application.Extencions
{
    public static class ApplicationExtencions
    {
        public static IServiceCollection AddApplication(this IServiceCollection Services)
        {
            //Inyeccion de servicios y mappers

            Services.AddScoped<IRead<ClienteDTO>, LeerClienteUseCase>();
            Services.AddScoped<ICreate<ClienteDTO>, RegistrarClienteUseCase>();
            Services.AddScoped<IUpdate<ClienteDTO>, ActualizarClienteUseCase>();
            Services.AddScoped<IDelete<ClienteDTO>, EliminarClienteUseCase>();
            Services.AddScoped<ILoginUseCase, LoginUseCase>();
            Services.AddScoped<IRealizarCompraUseCase, CompraService>();
            Services.AddScoped<IComprasByClienteUseCase, CompraService>();
            Services.AddScoped<IFiltrarComprasUseCase, CompraService>();
            Services.AddScoped<IRead<CompraDTO>, CompraService>();
            Services.AddScoped<IRead<CategoriaDTO>, LeerCategoriaUseCase>();
            Services.AddScoped<IRead<ProductoDTO>, LeerProductoUseCase>();
            Services.AddScoped<ICreate<ProductoDTO>, CrearProductoUseCase>();
            Services.AddScoped<IDelete<ProductoDTO>, EliminarProductoUseCase>();
            Services.AddScoped<IUpdate<ProductoDTO>, ActualizarProductoUseCase>();

            Services.AddAutoMapper(typeof(ApplicationMapperProfile));

            return Services;

        }
    }
}
