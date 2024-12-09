using Overloads;

Console.WriteLine("Oppgave: Overloads \n\n");
/*
    Test ut overloads og default verdier selv ved å lage 
    en metode PrintWelcomeMessage() som printer ut "Hei og velkommen".
   
    Lag en overload metode som kan ta inn et kompliment og legge det 
    til i velkomstmeldingen, dette navnet skal default være "Du er snill!", 
    med mindre noe annet er oppgitt.
 */

var welcome = new Welcome();
welcome.PrintMessage();
Thread.Sleep(1500);
welcome.PrintMessage("You're so cool!");