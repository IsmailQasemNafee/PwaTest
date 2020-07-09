using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace PwaTest.Books
{
    public class FilterBooksDto : PagedAndSortedResultRequestDto
    {
        public BookType? Type { get; set; }
    }
}
