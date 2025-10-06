using Marqdouj.HtmlCommon;
using Marqdouj.HtmlComponents.UI;

namespace Sandbox.Client.Pages
{
    public enum DemoEnum
    {
        One,
        Two,
        Three,
        Four,
        Five
    }

    public class UIInputModel : UIModel<UIInputValues>
    {
        public UIInputModel()
        {
            Color?.Description = "This is the description/tooltip for the Color property (nullable)";
            Color2?.Description = "This is the description/tooltip for the Color2 property (not nullable)";

            DoubleValue?.Description = "This is the description/tooltip for the DoubleValue property (not nullable)";
            DoubleValueN?.Description = "This is the description/tooltip for the DoubleValue2 property (nullable). Min:0 Max:1";
            DoubleValueN?.SetBindMinMax(0, 1);

            EnumValue?.Description = "This is the description/tooltip for the EnumValue property (nullable)";
            EnumValue2?.Description = "This is the description/tooltip for the EnumValue2 property (not nullable)";
            
            Flag?.Description = "This is the description/tooltip for the Flag property (nullable)";
            Flag2?.Description = "This is the description/tooltip for the Flag2 property (not nullable)";

            IntValue?.Description = "This is the description/tooltip for the IntValue property (not nullable)";
            IntValueN?.Description = "This is the description/tooltip for the IntValue2 property (nullable). Min:0 Max:360";
            IntValueN?.SetBindMinMax(0, 360);

            StringValue?.Description = "This is the description/tooltip for the StringValue property";

            Url?.Description = "This is the description/tooltip for the Url property";
        }

        public IUIModelValue? Color => GetItem(nameof(UIInputValues.Color));
        public IUIModelValue? Color2 => GetItem(nameof(UIInputValues.Color2));
        public IUIModelValue? DoubleValue => GetItem(nameof(UIInputValues.DoubleValue));
        public IUIModelValue? DoubleValueN => GetItem(nameof(UIInputValues.DoubleValueN));
        public IUIModelValue? EnumValue => GetItem(nameof(UIInputValues.EnumValue));
        public IUIModelValue? EnumValue2 => GetItem(nameof(UIInputValues.EnumValue2));
        public IUIModelValue? Flag => GetItem(nameof(UIInputValues.Flag));
        public IUIModelValue? Flag2 => GetItem(nameof(UIInputValues.Flag2));
        public IUIModelValue? IntValue => GetItem(nameof(UIInputValues.IntValue));
        public IUIModelValue? IntValueN => GetItem(nameof(UIInputValues.IntValueN));
        public IUIModelValue? StringValue => GetItem(nameof(UIInputValues.StringValue));
        public IUIModelValue? Url => GetItem(nameof(UIInputValues.Url));
    }

    public class UIInputValues
    {
        public HtmlColorName? Color { get; set; }
        public HtmlColorName Color2 { get; set; } = HtmlColorName.Azure;
        public double DoubleValue { get; set; }
        public double? DoubleValueN { get; set; }
        public DemoEnum? EnumValue { get; set; }
        public DemoEnum EnumValue2 { get; set; }
        public bool? Flag { get; set; }
        public bool Flag2 { get; set; } = true;
        public int IntValue { get; set; }
        public int? IntValueN { get; set; }
        public string? StringValue { get; set; }
        public string? Url { get; set; }
    }
}
