using Application.DTOs;
using Application.Excepciones;
using Application.Interfaces;
using Application.Interfaces.CRUD;
using Application.Interfaces.UseCases;
using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Cliente
{
    public class LoginUseCase : ILoginUseCase
    {

        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public LoginUseCase(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public async Task<ClienteDTO> Login(string email, string password)
        {
            var cliente = await _clienteRepository.GetByEmailAsync(email);
            if (cliente != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password, cliente.Contraseña))
                {
                    return _mapper.Map<ClienteDTO>(cliente);
                }
                else throw new IncorrectPasswordException("Contraseña incorrecta");
            }
            else throw new EmailAlreadyExistsException("El Email ingresado no esta registrado");
        }
    }
}
