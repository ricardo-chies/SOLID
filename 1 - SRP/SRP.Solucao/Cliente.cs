﻿using System;

namespace SOLID.SRP.Solucao
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool IsValid()
        {
            return EmailServices.IsValid(Email) && CPFServices.IsValid(CPF);
        }
    }
}