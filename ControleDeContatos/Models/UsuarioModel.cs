﻿using Data.Entities.Enuns;
using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome precisa ser informado!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O login precisa ser informado!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O email precisa ser informado!")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é válido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O email precisa ser informado!")]
        public EnumPerfil Perfil { get; set; }

        [Required(ErrorMessage = "A senha precisa ser informada!")]
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}
