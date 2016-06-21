using System.Data;

namespace Apskaita.BussinesLogicLayer
{
    public abstract class BussinesLogicLayerBase
    {
        public abstract DataTable GautiDuomenis();

        public abstract void IssaugotiDuomenis(DataRow updatedRow);
    }
}