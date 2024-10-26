namespace PuntoDeVenta.Primitives
{
    public enum OrderStatus
    {
        Pending,
        ReadyToPrepare,
        BeingPrepared,
        PreparationCompleted,
        ReadyToDispatch,
        Completed,
    }
}
