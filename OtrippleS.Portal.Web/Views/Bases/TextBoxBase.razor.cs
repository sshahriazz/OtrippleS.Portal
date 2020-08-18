using Microsoft.AspNetCore.Components;

namespace OtrippleS.Portal.Web.Views.Bases
{
    public partial class TextBoxBase
    {
        [Parameter]
        public string Value { get; set; }
        [Parameter]
        public string PlaceHolder { get; set; }
        public void setValue(string value) => this.Value = value;
    }
}
