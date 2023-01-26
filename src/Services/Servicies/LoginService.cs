﻿using AutoMapper;
using Data.Repositories.Interface;
using Services.DTO;
using Services.Servicies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Servicies
{
    public class LoginService : ILoginService
    {
        private readonly IUsuarioRepositorie _usuarioRepositorie;
        private readonly IMapper _mapper;

        public LoginService(IUsuarioRepositorie usuarioRepositorie, IMapper mapeer)
        {
            _usuarioRepositorie = usuarioRepositorie;
            _mapper = mapeer;
        }

        public async Task<LoginDTO> LoginAsync(LoginDTO loginDto)
        {
            var user = await _usuarioRepositorie.BuscarPorLoginSenha(loginDto.Login, loginDto.Senha);

            if(user != null)
            {
                return _mapper.Map<LoginDTO>(user);
            }

            return null;

        }
    }
}
