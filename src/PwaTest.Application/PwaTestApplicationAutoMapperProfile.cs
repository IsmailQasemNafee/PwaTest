using AutoMapper;
using PwaTest.Books;

namespace PwaTest
{
    public class PwaTestApplicationAutoMapperProfile : Profile
    {
        public PwaTestApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Book, BookDto>();
            CreateMap<CreateUpdateBookDto, Book>();

        }
    }
}
