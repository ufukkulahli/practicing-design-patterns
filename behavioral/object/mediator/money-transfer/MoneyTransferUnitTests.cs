using Xunit;
using Xunit.Abstractions;

namespace practicing_design_patterns.behavioral.@object.mediator.moneytransfer
{
  public class MoneyTransferUnitTests
  {
    public static ITestOutputHelper OutputHelper;

    public MoneyTransferUnitTests(ITestOutputHelper outputHelper)
    {
      OutputHelper = outputHelper;
    }

    [Fact]
    public void TestThatParticipantsCanSendMoneyToEachOther()
    {
      // Arrange
      var euCitizenOliver = new EUCitizen(new EuroAccount(), "Oliver Newman");
      var usaCitizenMichael = new USACitizen(new DollarAccount(), "Michael Smith");
      var globalTransferCo = new GlobalTransferCO();
      globalTransferCo.Register(euCitizenOliver, usaCitizenMichael);

      // Act
      euCitizenOliver.Send(usaCitizenMichael, new Amount(500, new Currency("$")));
      usaCitizenMichael.Send(euCitizenOliver, new Amount(100, new Currency("€")));


      // Assert
      Assert.Equal(new decimal(500), usaCitizenMichael.Account.Balance.Get());
      Assert.Equal(new decimal(100), euCitizenOliver.Account.Balance.Get());
    }
  }
}