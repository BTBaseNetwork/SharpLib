using System;
using Xunit;

namespace SharpLib.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var utcNow = DateTime.UtcNow;
            var now = DateTime.Now;

            Console.WriteLine("UtcNowTicks:{0}", utcNow.Ticks);
            Console.WriteLine("NowTicks:{0}", now.Ticks);

            var utcNowTS = BahamutCommon.Utils.DateTimeUtil.UnixTimeSpanOfDateTime(utcNow);
            var nowTS = BahamutCommon.Utils.DateTimeUtil.UnixTimeSpanOfDateTime(now);

            Console.WriteLine("UtcNowUnixTimeSpan:{0}", utcNowTS);
            Console.WriteLine("NowUnixTimeSpan:{0}", nowTS);

            Console.WriteLine("UtcNowUnixTimeSpanSeconds:{0}", utcNowTS.TotalSeconds);
            Console.WriteLine("NowUnixTimeSpanSeconds:{0}", nowTS.TotalSeconds);

            Console.WriteLine("Test");

            Assert.Equal(utcNowTS.TotalSeconds, nowTS.TotalSeconds);
        }
    }
}
