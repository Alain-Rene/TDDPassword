using MyProject;
using Xunit;
namespace MyProject.Tests;

public class UnitTest1
{
    
    [Theory]
    [InlineData("admin", true)]
    [InlineData("mod", true)]
    [InlineData("pAsswOrd1", true)]
    [InlineData("h4CkErShIt", true)]
    [InlineData("password", false)]
    [InlineData("HEllo WOr1d", false)]
    [InlineData("ZXCV1", false)]
    [InlineData("PrInglE5", true)]
    public void PasswordTesting(string pass, bool expected)
    {
       
        //Arrange
        List<string> passwords = new List<string> {"Example1", "Example2"};
        
        bool result = PasswordHolder.AddPassword(pass, passwords);

        Assert.Equal(expected, result);
    }
    [Fact]
    public void PasswordHasOneNumber()
    {
        List<string> passwords = new List<string>();
        string password = "passw0rd";
        
    }
}