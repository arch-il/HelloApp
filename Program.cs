using System.Threading;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

/*
app.Run(async (context) =>
{
    // shevqmeni for loop sadac counter imatebs 1-it da gamoaqvs yovel 1 wamshi
    for (int counter = 0; counter < 100; counter++)
    {
        Console.WriteLine($"{counter}");
        await context.Response.WriteAsync($"{counter}\n");
        await Task.Delay(100);
    }
    // problema is aris rom ar gamoaqvs araferi manam, sanam for loop ar dasruldeba
});


// vcade app-is gashveba
// app.Run();

// asinqronulad gashveba
// await app.RunAsync();
// await app.StopAsync();
*/

// vcade titoeuli gamotana calke damewera magram refresh-is gareshe ar mushaobda
int counter = 0;
app.Run(async (context) =>
{
    Console.WriteLine($"{counter}");
    await context.Response.WriteAsync($"{counter}\n");
    counter++;
});


while (true)
{
    await app.RunAsync();
    await Task.Delay(1000);
    await app.StopAsync();
}