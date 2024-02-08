
class HealingPotion : Potion
{
    public HealingPotion(string name, int health) 
    : base(name, new())
    {
        Attributes.Add(ItemAttributesEnum.Health, health);
    }
}