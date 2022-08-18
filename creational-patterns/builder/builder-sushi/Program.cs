
Console.WriteLine("Hello Builder in Real World!");

// Clients can create Sushi in two different ways:

// Option A: using the Director

KyotoDirector director = new ();

UramakiBuilder uramakiBuilder = new ();

Sushi rainbowRoll = director.BuildRainbowRoll(uramakiBuilder);
rainbowRoll.Show();

// Option B: create a custom suchi using a concrete builder

MakiBuilder makiBuilder = new ();

makiBuilder.Reset();
makiBuilder.BuildRice();
makiBuilder.BuildNori();
makiBuilder.BuildFish("Salmon");
makiBuilder.BuildVeggie("Bunch onion");
makiBuilder.BuildSauce("Cream Cheese");
Sushi tokyoRoll = makiBuilder.GetRoll();
tokyoRoll.Show();