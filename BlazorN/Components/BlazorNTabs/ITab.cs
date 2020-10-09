using Microsoft.AspNetCore.Components;

namespace BlazorN
{
    public interface ITab
    {
        RenderFragment ChildContent { get; set; }
    }
}
