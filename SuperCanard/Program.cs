//using SuperConnard.Canard;
//using SuperConnard.Comportements;

//List<Canard> canards = new List<Canard>()
//{
//    new CanardEnPlastique(),
//    new Colvert(),
//    new Leurre(),
//    new Mandarin(),
//};

//canards[3].ComportementCanCan = new Begayer(new Cancan());
//canards[2].ComportementCanCan = new Alternant(new Cancan(), new Coincoin());

////foreach (var c in canards)
////{
////    Console.WriteLine("\n"+c.GetType().Name);
////    c.EffectuerCancan();
////    c.EffectuerVol();
////}

//canards[2].EffectuerCancan();
////canards[2].EffectuerCancan();

//using SuperConnard;
//using SuperConnard.Canard;

//Chasseur c = Chasseur.GetInstance();
//IAnimal canard = new CanardAnimal(new Colvert());
//c.Tirer(canard);

using SuperCanard;
using SuperCanard.Canard;

ComportementFactory factory = new();

Console.Write($"Cancan =>");  factory.GetCan().Cancaner();
Console.Write($"Coincoin =>");  factory.GetCoin().Cancaner();
Console.Write($"GetCanCan =>");  factory.GetCanCan().Cancaner();
Console.Write($"GetCoinCoin =>");  factory.GetCoinCoin().Cancaner();
Console.Write($"GetMuet =>");  factory.GetMuet().Cancaner();
Console.Write($"GetAltCanCoin =>");  factory.GetAltCanCoin().Cancaner();
Console.Write($"GetAltCoinCan =>");  factory.GetAltCoinCan().Cancaner();
Console.Write($"GetCoinCan =>");  factory.GetCoinCan().Cancaner();
Console.Write($"GetCanCoin =>");  factory.GetCanCoin().Cancaner();
Console.Write($"GetCanCanCoin =>");  factory.GetCanCanCoin().Cancaner();


Console.WriteLine(factory.GetCoin() == factory.GetCoin());
Console.WriteLine(factory.GetCan() == factory.GetCan());
Console.WriteLine(factory.GetAltCanCoin() == factory.GetAltCanCoin());

ICanard ligne = new CanardLigne(new Colvert());
ligne.EffectuerVol();
ligne.EffectuerCancan();

ICanard bavard = new CanardBavard(new Colvert());
bavard.EffectuerVol();
bavard.EffectuerCancan();


