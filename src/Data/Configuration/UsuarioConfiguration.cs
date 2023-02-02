﻿using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {


        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario");
            builder.HasKey(x => x.Id).HasName("id");
            builder.Property(p => p.Nome).HasColumnType("VARCHAR(50)").HasColumnName("nome");
            builder.Property(p => p.Login).HasColumnType("VARCHAR(50)").HasColumnName("login");
            builder.Property(p => p.Email).HasColumnType("VARCHAR(50)").HasColumnName("email");
            builder.Property(p => p.Perfil).HasColumnType("CHAR(2)").HasColumnName("perfil").HasConversion<int>();
            builder.Property(p => p.Senha).HasColumnType("VARCHAR(150)").HasColumnName("senha");
            builder.Property(p => p.DataCadastro).HasColumnType("DATETIME").HasColumnName("data_cadastro");
            builder.Property(p => p.DataAtualizacao).HasColumnType("DATETIME").HasColumnName("data_atualizacao");



        }
    }
}
