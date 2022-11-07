using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Learning_Dashboard_Final.Pages;

namespace TestLearning_Dashboard_Final
{
	public class TestProfile
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor();
			var componentUnderTest = ctx.RenderComponent<Profile>();
			Assert.NotNull(componentUnderTest);
		}
	}
}