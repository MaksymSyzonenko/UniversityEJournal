using University_E_Journal_PostgreSQL.Data.Entities.Abstract;

namespace University_E_Journal.BuisnessLogic.Base
{
    public abstract class Report<TEntity> where TEntity : BaseEntity
    {
        protected readonly TEntity _entity;
        protected readonly List<ReportPart<TEntity>> Parts = new();
        public IEnumerable<ReportPart<TEntity>> AllParts => Parts;
        public Report(TEntity entity)
        {
            _entity = entity;
        }
        public string GetStringReport()
        {
            if (!Parts.Any())
                CreateReport();
            string report = string.Empty;
            Parts.ForEach(p => report += p.GetStringReportPart() + " ");
            return report;
        }
        protected abstract void CreateReport();
    }
}
