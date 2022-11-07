using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Learning_Dashboard_Final.Pages;
using Learning_Dashboard_Final.LearningApp;

namespace TestLearning_Dashboard_Final
{
	public class TestCourses
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbListModule),
				typeof(IgniteUI.Blazor.Controls.IgbChipModule),
				typeof(IgniteUI.Blazor.Controls.IgbAvatarModule),
				typeof(IgniteUI.Blazor.Controls.IgbExpansionPanelModule));
			var mockHttpClient = new MockHttpClient().Create();
			ctx.Services.AddSingleton(new LearningAppService(mockHttpClient));
			var componentUnderTest = ctx.RenderComponent<Courses>();
			Assert.NotNull(componentUnderTest);
		}
	}
}