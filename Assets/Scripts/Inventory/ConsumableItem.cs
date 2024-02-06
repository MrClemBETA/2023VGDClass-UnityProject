using UnityEngine;

namespace SOS.AndrewsAdventure.Inventory
{
    [CreateAssetMenu(fileName = "baseItem", menuName = "Andrew's Adventure/Inventory Consumable", order = 8)]
    public class ConsumableItem : BaseItem
    {
        [SerializeField] int stackSize;
    }
}
