using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace NetRevision.Pages;

public class Index_Tests : NetRevisionWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
