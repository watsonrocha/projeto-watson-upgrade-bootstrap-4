﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAtividadeEntrevista.Controllers;

namespace WebAtividadeEntrevista.Models
{
    /// <summary>
    /// Classe de Modelo de Cliente
    /// </summary>
    public class ClienteModel
    {
        public ClienteModel()
        {
            Beneficiarios = new List<BeneficiarioModel>();

        }

        public ICollection<BeneficiarioModel> Beneficiarios { get; set; }

        public long Id { get; set; }
        
        /// <summary>
        /// CEP
        /// </summary>
        [Required]
        public string CEP { get; set; }

        /// <summary>
        /// Cidade
        /// </summary>
        [Required]
        public string Cidade { get; set; }

        /// <summary>
        /// E-mail
        /// </summary>
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Digite um e-mail válido")]
        public string Email { get; set; }

        /// <summary>
        /// Estado
        /// </summary>
        [Required]
        [MaxLength(2)]
        public string Estado { get; set; }

        /// <summary>
        /// Logradouro
        /// </summary>
        [Required]
        public string Logradouro { get; set; }

        /// <summary>
        /// Nacionalidade
        /// </summary>
        [Required]
        public string Nacionalidade { get; set; }

        /// <summary>
        /// CPF
        /// </summary>
        [Required(ErrorMessage = "Informe o CPF ou CNPJ do Cliente", AllowEmptyStrings = false)]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        /// <summary>
        /// Nome
        /// </summary> 
        [Required]
        public string Nome { get; set; }

        /// <summary>
        /// Sobrenome
        /// </summary>
        [Required] 
        public string Sobrenome { get; set; }

        /// <summary>
        /// Telefone
        /// </summary>
        public string Telefone { get; set; }



    }    
}