using System;
using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@object.mediator.chat
{
  public class Mediator : IMediator
  {
    private ICollection<Friend> participants = new List<Friend>();

    public void Register(Friend friend)
    {
      this.participants.Add(friend);
    }

    public void Send(Friend friend, string message)
    {
     if(participants.Contains(friend))
     {
       ChatUnitTests.OutputHelper.WriteLine
        ("Name: {0}, Message: {1}, Time: {2}", friend.Name, message, DateTime.Now);
       return;
     }

     ChatUnitTests.OutputHelper.WriteLine
      ("An outsider named {0} trying to send message: {1}", friend.Name, message);
    }

    public void DisplayDetails()
    {
      ChatUnitTests.OutputHelper.WriteLine("For now participants are:");
      foreach(var participant in participants)
      {
        ChatUnitTests.OutputHelper.WriteLine("{0}", participant.Name);
      }
    }
  }
}
