using University_E_Journal_PostgreSQL.Data.Entities.Abstract;

namespace University_E_Journal.BuisnessLogic.Base
{
    public abstract class ReportPart<TEntity> where TEntity : BaseEntity
    {
        public abstract string GetStringReportPart();
    }
}
