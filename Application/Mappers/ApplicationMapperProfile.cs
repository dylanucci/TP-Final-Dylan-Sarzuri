using Application.DTOs;
using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public class ApplicationMapperProfile : Profile
    {
        public ApplicationMapperProfile()
        {
            CreateMap<ClienteEntity, ClienteDTO>();
            CreateMap<ClienteDTO, ClienteEntity>();
            CreateMap<CompraEntity, CompraDTO>();
            CreateMap<CompraDTO, CompraEntity>();
            CreateMap<ProductoEntity, ProductoDTO>();
            CreateMap<ProductoDTO, ProductoEntity>();
            CreateMap<DetalleDTO, DetalleEntity>();
            CreateMap<DetalleEntity, DetalleDTO>();
            CreateMap<CategoriaEntity, CategoriaDTO>();
            CreateMap<CategoriaDTO, CategoriaEntity>();
            CreateMap<CategoriaEntity, CategoriaDTO>();
        }
    }
}
