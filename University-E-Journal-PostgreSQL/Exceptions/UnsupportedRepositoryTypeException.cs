namespace University_E_Journal_PostgreSQL.Exceptions
{
    public sealed class UnsupportedRepositoryTypeException : Exception
    {
        public UnsupportedRepositoryTypeException(string typeName) : base(typeName)
        {
        }
    }
}

