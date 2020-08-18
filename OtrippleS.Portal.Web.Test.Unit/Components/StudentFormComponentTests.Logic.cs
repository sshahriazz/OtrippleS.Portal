using FluentAssertions;
using OtrippleS.Portal.Web.Models.Basics;
using OtrippleS.Portal.Web.Views.Components;
using Xunit;

namespace OtrippleS.Portal.Web.Test.Unit.Components
{
    public partial class StudentFormComponentTests
    {

        [Fact]
        public void shouldInitializeComponent()
        {
            // given - when
            var initialStudnetFormComponent = new StudentFormComponent();

            // then
            initialStudnetFormComponent.StudentNameTextBox.Should().BeNull();
        }
        [Fact]
        public void shouldRenderComponent()
        {
            // given
            ComponentState expectedState = ComponentState.Content;

            //when
            this.renderedStudentFormComponent = RenderComponent<StudentFormComponent>();

            //then
            this.renderedStudentFormComponent.Instance.State.Should().BeEquivalentTo(expectedState);
            this.renderedStudentFormComponent.Instance.StudentNameTextBox.Should().NotBeNull();
            this.renderedStudentFormComponent.Instance.StudentNameTextBox.PlaceHolder.Should().BeEquivalentTo("Name");

        }
    }
}
