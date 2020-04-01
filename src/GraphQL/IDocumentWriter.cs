namespace GraphQL
{
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IDocumentWriter
    {
        Task WriteAsync<T>( Stream stream, T value, CancellationToken cancellationToken = default );
    }
}
