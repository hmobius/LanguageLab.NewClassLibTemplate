namespace LanguageLab.NewClassLib.Tests
{
    using LanguageLab.NewClassLib;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("Hello", new Class1().Hello());
        }
    }
}
