using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroGame
{
    class Wizard : Hero , ISpecialAttack
    {
        public Wizard(string name, int fullhp, Colors color) : base(name, fullhp, color)
        {

        }

        public override void DefaultAttack(Hero hero)
        {
            int hp = rnd.Next(100, 151);
            hero.ActualHP -= hp;
            Console.WriteLine($"\nGracz {Name} zadał {hp} punktów obrażeń graczowi {hero.Name}.");
        }

        public override void Heal()
        {
            int hp = rnd.Next(100, 201);
            ActualHP += hp;
            Console.WriteLine($"Gracz {Name} uzdrowił się za {hp} punkitów hp.");
        }

        public void SpecialAttack(Hero hero)
        {
            int hp = rnd.Next(250, 301);
            hero.ActualHP -= hp;
            Console.WriteLine($"\nGracz  {Name} wykonał atak specjalny za {hp} punktów obrażeń graczowi {hero.Name}.");
        }
    }
}
