using EFCore6.Core.Repositories;

namespace EFCore6.Core.Repositories
{
    public interface IPubContextUnitOfWork
    {
        IAuthorRepository AuthorRepository { get; }
        IBooksRepository BooksRepository { get; }
        Task SaveChanges();
    }
}