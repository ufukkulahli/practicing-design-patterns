using Xunit;

namespace practicing_design_patterns.structural.@object.flyweight.company
{
  public class CompanyUnitTests
  {
    [Fact]
    public void VerifyCompanyInfo()
    {
      // Arrange
      var orangeCompany = new Company("Orange", "USA");

      // Act && Assert
      Assert.Equal("Orange", orangeCompany.Name);
      //TODO
      //Assert.Equal("A huge agreement file", orangeCompany.Agreement);
      Assert.Equal("", orangeCompany.Agreement);
    }
  }
}
