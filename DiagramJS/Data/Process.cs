using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace DiagramJS.Data
{
    public class Process : NodeModel
    {
        public Process() : base(Point.Zero)
        {
        }

        public Process(Point position) : base(position)
        {
        }

        public string Segment { get; set; } = string.Empty;
        public string Material { get; set; } = string.Empty;
    }
}