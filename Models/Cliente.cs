using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace TorresJ_EvaluacionP1.Models
{
    public class Cliente
    {
        //Clientes:
        //  Agregue como mínimo, -1 atributo de tipo int, -1 campo tipo decimal, -1 campo tipo string, -1 campo tipo bool
        //  y un campo de -tipo fecha.Se debe incluir un atributo que sea su nombre.Ej CordovaS.Utilice al menos 5 validaciones
        //  diferentes (Data Annotations) para controlar los datos ingresados por el usuario en la nueva tabla.

        [Key]
        public int IdCliente { get; set; }
        [MaxLength(100)]
        [Required]
        [DisplayName("Ingrese el nombre: ")]
        public string NombreCliente { get; set; }
        public string NombreCreador 
        {
            get
            {
                return "TorresJulian";
            }
        }
        [DisplayName("Edad")]
        [Range(18, 100)]
        public int Edad { get; set; }
        [DataType(DataType.Currency)]
        public decimal SaldoDisponible { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public bool EsVip { get; set; }
        public bool TieneReserva { get; set; }
        [DisplayName("Fecha Actual")]
        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; }
        public int IdRecompensaCliente { get; set;}
        [ForeignKey ("IdRecompensaCliente")]
        public Recompensas? Recompensas { get; set; }


    }
}

