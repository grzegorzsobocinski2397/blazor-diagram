# Diagram functionality in Blazor
Investigate possible solutions of flowcharts/diagrams in Blazor. 

## Findings
The best solution is [Blazor diagrams](https://blazor-diagrams.zhaytam.com/quickstart). Using JavaScript (npm package) is hard to maintain and can quickly cause a lot of bugs, because we need to adapt existing interface/methods (JS code) to the Blazor one. It's best to use a NuGet package where we have strong typing.

I've tried implementing [diagram-js](https://github.com/bpmn-io/diagram-js) but it adds a lot of complexity (WebPack, build process etc.). 
