using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNovelGenerator.Model
{
    public class Book
    {
        private string Title { get; init; } = "";
        private List<Chapter> Chapters { get; init; } = [];
    }
}
