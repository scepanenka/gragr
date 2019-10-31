using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace GrAGR.Pages
{
    public class Index_Tests : GrAGRWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
