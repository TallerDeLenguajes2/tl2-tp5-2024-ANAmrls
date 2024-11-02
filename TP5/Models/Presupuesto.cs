namespace TP5.Models
{
    public class Presupuesto
    {
        private int idPresupuesto;
        private string nombreDestinatario;
        List<PresupuestoDetalle> detalle;

        public Presupuesto(int idPresupuesto, string nombreDestinatario)
        {
            this.idPresupuesto = idPresupuesto;
            this.nombreDestinatario = nombreDestinatario;
            this.detalle = new();
        }

        public int IdPresupuesto { get => idPresupuesto; set => idPresupuesto = value; }
        public string NombreDestinatario { get => nombreDestinatario; set => nombreDestinatario = value; }
        public List<PresupuestoDetalle> Detalle { get => detalle; set => detalle = value; }
    }
}
