using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Application.DTOs;
using Application.Interfaces.CRUD;
using Application.Interfaces.UseCases;
using Application.Mappers;
using Application.UseCases.Administrador;
using Application.UseCases.Cliente;
using Domain;
using Application.Interfaces;
using Infraestructure.Repositories;
using Infraestructure.Mappers;

namespace Infraestructure.Extencions
{
    public static class InfreastructureServiceCollectionExtensions
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection Services, IConfiguration Configuration)
        {
            Services.AddDbContext<GestionventasContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            Services.AddScoped<IClienteRepository, ClienteRepository>();
            Services.AddScoped<IProductoRepository, ProductoRepository>();
            Services.AddScoped<ICompraRepository, CompraRepository>();
            Services.AddScoped<IRead<CategoriaEntity>, CategoriaRepository>();

            Services.AddAutoMapper(typeof(InfraestructureMapperProfile));

            return Services;
        }
    }
}
