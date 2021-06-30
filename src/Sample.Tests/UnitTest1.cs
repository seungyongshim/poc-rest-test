using System;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Xunit;

namespace Sample.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            dynamic person = await "http://api.com"
                .AppendPathSegment("person")
                .SetQueryParams((a: 1, b: 2))
                .PostJsonAsync((
                   first_name: "Claire",
                   last_name: "Underwood"
                ))
                .ReceiveJson();
        }
    }
}
