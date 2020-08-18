using Microsoft.AspNetCore.Components;
using OtrippleS.Portal.Web.Models.Basics;
using OtrippleS.Portal.Web.Views.Bases;

namespace OtrippleS.Portal.Web.Views.Components
{
    public partial class StudentFormComponent : ComponentBase
    {
        public TextBoxBase StudentNameTextBox { get; set; }

        public ComponentState State { get; set; }

        protected override void OnInitialized()
        {
            this.State = ComponentState.Content;
        }

    }
}
