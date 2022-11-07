using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Learning_Dashboard_Final.Pages;
using Learning_Dashboard_Final.LearningApp;

namespace TestLearning_Dashboard_Final
{
	public class TestDashboard
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbCardModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbIconButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbListModule),
				typeof(IgniteUI.Blazor.Controls.IgbAvatarModule),
				typeof(IgniteUI.Blazor.Controls.IgbChipModule),
				typeof(IgniteUI.Blazor.Controls.IgbCheckboxModule));
			var mockHttpClient = new MockHttpClient().Create();
			ctx.Services.AddSingleton(new LearningAppService(mockHttpClient));
			var componentUnderTest = ctx.RenderComponent<Dashboard>();
			Assert.NotNull(componentUnderTest);
		}
	}
}