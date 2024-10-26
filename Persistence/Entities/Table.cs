using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.Persistence.Configuration;

namespace PuntoDeVenta.Persistence.Entities
{
    [EntityTypeConfiguration(typeof(TableConfiguration))]
    public class Table
    {
        public Table(int number, int seats, string? description = null)
        {
            Number = number;
            Description = description;
            Seats = seats;
            IsAvailable = true;
        }

        public Table() { }

        public Guid Id { get; set; }
        public int Number { get; set; }
        public string? Description { get; set; }
        public int Seats { get; set; }
        public bool IsAvailable { get; set; }
    }
}
