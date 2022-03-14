# Diagram functionality in Blazor
Investigate possible solutions of flowcharts/diagrams in Blazor. 

## Findings
My favorite solution is [Blazor diagrams](https://blazor-diagrams.zhaytam.com/quickstart). Using JavaScript (npm package) is hard to maintain and can quickly cause a lot of bugs, because we need to adapt existing interface/methods (JS code) to the Blazor one. It's best to use a NuGet package where we have strong typing. Blazor diagrams package allows us to create custom component for the nodes and the connections. 

<img width="456" alt="image" src="https://user-images.githubusercontent.com/43864376/158135099-b06b4e7d-9b71-4f88-bc66-d60c5dc2efff.png">

I've tried implementing [diagram-js](https://github.com/bpmn-io/diagram-js) but it adds a lot of complexity (WebPack, build process etc.). 
