using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNovelGenerator.Model
{
    internal class Chapter
    {
        private string? Heading { get; init; }
        private List<string> Sections { get; init; } = [];
    }
}
