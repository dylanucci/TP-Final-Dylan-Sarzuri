using Application.DTOs;
using AutoMapper;
using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Mappers
{
    public class InfraestructureMapperProfile : Profile
    {
        public InfraestructureMapperProfile() 
        {
            CreateMap<ClienteEntity, Cliente>();
            CreateMap<Cliente, ClienteEntity>();
            CreateMap<CompraEntity, Compra>();
            CreateMap<Compra, CompraEntity>();
            CreateMap<ProductoEntity, Producto>();
            CreateMap<Producto, ProductoEntity>();
        }    
    }
}
