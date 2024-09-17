using Microsoft.AspNetCore.Components;

namespace BlazorApp2.Components.Pages
{
    public partial class DemoComponent
    {
        [Parameter]
        public string Text { get; set; }
    }
}
