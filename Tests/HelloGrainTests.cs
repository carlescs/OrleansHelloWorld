using System.Collections.Generic;
using System.Threading.Tasks;
using GrainInterfaces;
using Microsoft.Extensions.Configuration;
using Orleans.TestingHost;
using Xunit;

namespace Tests
{
    public class HelloGrainTests
    {

        [Fact]
        public async Task SaysHelloCorrectly()
        {
            var cluster = new TestCluster(new TestClusterOptions{}, new List<IConfigurationSource>());
            cluster.Deploy();

            var hello = cluster.GrainFactory.GetGrain<IHello>(0);
            var greeting = await hello.SayHello("Hola");

            cluster.StopAllSilos();

            Assert.Equal("Hello, World", greeting);
        }
    }
}
