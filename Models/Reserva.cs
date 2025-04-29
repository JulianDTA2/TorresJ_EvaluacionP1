using System.ComponentModel.DataAnnotations.Schema;

namespace TorresJ_EvaluacionP1.Models
{
    public class Reserva
    {
        //Reserva: Se debe incluir la fecha de la reserva (entrada y salida), valor a pagar e información del cliente.
        public int IdReserva { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Salida { get; set; }
        public double ValorPago { get; set; }
        public int InfoIdCliente { get; set; }
        [ForeignKey("InfoIdCliente")]
        public Cliente? Cliente { get; set; }

    }
}
