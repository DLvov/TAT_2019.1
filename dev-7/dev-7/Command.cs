namespace dev_7
{
    /// <summary>
    /// This class is abstract command.
    /// </summary>
    abstract class Command
    {
        public VehicleCatalog Catalog { get; set; }
        public abstract void Execute();
    }
}