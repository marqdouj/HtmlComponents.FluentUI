using Marqdouj.HtmlCommon;
using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;

namespace Marqdouj.HtmlComponents.FluentUI.UIInput
{
    /// <summary>
    /// <see href="https://www.fluentui-blazor.net/Tooltip"/>
    /// </summary>
    public class TooltipOptions
    {
        /// <summary>
        /// <see cref="FluentTooltip.Delay"/>
        /// </summary>
        public int? Delay { get; set; }

        [Parameter]
        public List<HtmlColorNameListItem>? Colors { get; set; }

        /// <summary>
        /// <see cref="FluentTooltip.MaxWidth"/>
        /// </summary>
        public string? MaxWidth { get; set; }

        /// <summary>
        /// <see cref="FluentTooltip.Position"/>
        /// </summary>
        public TooltipPosition? Position { get; set; }
    }
}
