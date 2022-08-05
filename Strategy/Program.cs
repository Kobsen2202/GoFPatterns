using Strategy;
using Strategy.Strategies;

Hero hero = new("Squidward");

hero.Attack();

hero.SetWeapon(new Broom());

hero.Attack();

hero.SetWeapon(new Plunger());

hero.Attack();

Console.ReadLine();