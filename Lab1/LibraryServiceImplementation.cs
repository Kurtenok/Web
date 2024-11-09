using System.Threading.Tasks;
using Grpc.Core;
using Lab1;

public class LibraryServiceImplementation : LibraryService.LibraryServiceBase
{
    private readonly LibraryContext _context;

    public LibraryServiceImplementation(LibraryContext context)
    {
        _context = context;
    }

    public override async Task<BookResponse> AddBook(BookRequest request, ServerCallContext context)
    {
        // Добавление книги в базу данных
        var book = new Book
        {
            Id = request.Id,
            Title = request.Title,
            Author = request.Author,
            LibraryNumber = request.LibraryNumber
        };

        _context.Books.Add(book);
        await _context.SaveChangesAsync();

        return new BookResponse
        {
            Success = true,
            Message = "Book added successfully"
        };
    }

    public override async Task<BookResponse> GetBook(BookIdRequest request, ServerCallContext context)
    {
        // Поиск книги по ID
        var book = await _context.Books.FindAsync(request.Id);

        if (book == null)
        {
            return new BookResponse
            {
                Success = false,
                Message = "Book not found"
            };
        }

        return new BookResponse
        {
            Success = true,
            Message = $"Found book: {book.Title}, {book.Author}"
        };
    }
}
