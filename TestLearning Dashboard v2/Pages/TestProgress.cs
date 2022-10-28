using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Learning_Dashboard_v2.Pages;

namespace TestLearning_Dashboard_v2
{
	public class TestProgress
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor();
			var componentUnderTest = ctx.RenderComponent<Progress>();
			Assert.NotNull(componentUnderTest);
		}
	}
}