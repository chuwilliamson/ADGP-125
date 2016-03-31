 
namespace MarvelRPG
{
    public interface IDamager
    {
        /// <summary>
        /// OUTGOING DAMAGE
        /// </summary>
        /// <returns>return how much damage was SENT</returns>
        float Damage { get; }
    }
    public interface IDamageable //do damage and take damage
    {
        /// <summary>
        /// INCOMING DAMAGE
        /// </summary>
        /// Perform damage on an object, it is the implementing class's responsibility to perform the
        /// damage mitigation
        void TakeDamage(int amount);
    }
    public interface IBaseStat
    {
        int Health { get; set; }
        int Resource { get; set; }
    }
    public interface IAttributes
    {
 
        /// <summary>
        ///Durability Every point provides:
        ///Total Physical Defense Rating: +2%
        ///Total Energy Defense Rating: +2%
        ///Maximum Health per Level: +3
        ///Health Regeneration: +2 per second
        ///Incoming Stun Duration Reduction: 1%
        /// </summary>
        int Durability { get; set; }

        /// <summary>
        ///Strength Every point provides:
        ///Physical Damage: +4%
        ///Thrown Object Damage: +4%
        ///Reduced Spirit Cost for Physical Powers: 1%
        ///At Strength 4 and above, you can throw heavy objects and cars.
        ///</summary>
        int Strength { get; set; }

        /// <summary>
        ///Fighting Every point provides:
        ///Damage for All Powers: +3%
        ///Brutal Strike Rating per Level: +1
        ///Brutal Damage Rating per Level: +3
        /// </summary>
        int Fighting { get; set; }

        /// <summary>
        ///Speed Every point provides:
        ///Movement Speed: +1%
        ///Attack Speed: +1%
        ///Movement Power Damage: +2%
        ///Spirit Cost Reduction for Movement Powers: 1%
        ///Dodge Rating per Level: +1
        ///Tenacity per Level: +0.25
        /// </summary>
        int Speed { get; set; }

        /// <summary>
        /// Energy Every point provides:
        ///Energy Damage: +4%
        ///Mental Damage: +4%
        ///Reduced Spirit Cost for Mental Powers: 1%
        ///Reduced Spirit Cost for Energy Powers: 1%
        /// </summary>
        int Energy { get; set; }

        /// <summary>
        ///Intelligence Every point provides:
        ///Total Mental Defense Rating: +2%
        ///Critical Rating per Level: +0.5
        ///Critical Damage Rating per Level: +1.5
        ///Maximum Spirit: +2
        ///Experience Gained: +1%
        ///Summoned Ally Damage: +4%
        /// </summary>
        int Intelligence { get; set; }
    }

    public interface IAbility
    {
        int cost { get; set; }
        int power { get; set; }
        void Execute();
    }

    
}
//when to make decisions?
//
