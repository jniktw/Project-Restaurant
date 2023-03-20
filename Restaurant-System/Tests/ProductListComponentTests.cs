using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Restaurant_System.Client.Pages;
using RichardSzalay.MockHttp;
using System.Net;
using System.Text.Json;

namespace Restaurant_System.Tests
{
    public class ProductListComponentTests : TestContext
    {
        [Fact]
        public void TestRenderProductListWithHttpClient()
        {
            var content = @"[{""id"":6,""productName"":""banan"",""actualNumber"":0,""requiredNumber"":5,""unit"":""szt""}]";

            var mockHttp = new MockHttpMessageHandler();
            var httpClient = mockHttp.ToHttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:7139");
            Services.AddSingleton(httpClient);

            mockHttp.When("/ProductList")
                    .Respond(HttpStatusCode.OK, "application/json", content);

            var cut = RenderComponent<ProductList>();
            cut.WaitForAssertion(() => Assert.NotNull(cut.Instance));

        }
    }
}