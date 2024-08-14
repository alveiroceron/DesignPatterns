

using Mediator.Console;

var mediator = new Mediator.Console.Mediator();

var Ana = new ColleagueA(mediator, "Ana");
var Luis = new ColleagueA(mediator, "Luis");
var David = new ColleagueB(mediator, "David");

Ana.Send("Greetings for all");
Luis.Send("Hou are you guys?");
David.Send("Visit my profile");
Console.WriteLine();

Console.WriteLine("****** Verify Censure ******");
Luis.Send("this is a palabrota");
Console.WriteLine();

mediator.Blocking(Luis.Receive);
Ana.Send("check the playlist");
Console.WriteLine();


mediator.Subscribe(Luis.Receive);
David.Send("I like programming");
Console.WriteLine();