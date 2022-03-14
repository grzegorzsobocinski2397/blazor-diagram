using Blazor.Diagrams.Core;
using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;
using BlazorDiagram.Data;

namespace BlazorDiagram.Pages
{
    public partial class Index
    {
        public Diagram Diagram { get; set; } = new();

        protected override void OnInitialized()
        {
            Setup();
        }

        private void Setup()
        {
            Diagram.RegisterModelComponent<Process, CustomNodeComponent>();

            var rootNode = new Process(new Point(50, 50));
            rootNode.AddPort(PortAlignment.Bottom);
            rootNode.Material = "SM";
            rootNode.Title = "Process";

            var childNode = new Process(new Point(50, 300));
            childNode.AddPort(PortAlignment.Bottom);
            childNode.AddPort(PortAlignment.Top);
            rootNode.Material = "Custom";
            childNode.Title = "Manufacturing";

            var grandChildNode = new Process(new Point(50, 600));
            grandChildNode.AddPort(PortAlignment.Top);
            grandChildNode.Title = "Smart";

            Diagram.Nodes.Add(new[] { rootNode, childNode, grandChildNode });
            Diagram.Links.Add(new LinkModel(rootNode.GetPort(PortAlignment.Bottom), childNode.GetPort(PortAlignment.Top)));
            Diagram.Links.Add(new LinkModel(childNode.GetPort(PortAlignment.Bottom), grandChildNode.GetPort(PortAlignment.Top)));
        }
    }
}