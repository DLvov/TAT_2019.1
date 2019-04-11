namespace dev_7
{
    abstract class Command
    {
        public VehicleCatalog Catalog { get; set; }
        public abstract void Execute();
    }
}