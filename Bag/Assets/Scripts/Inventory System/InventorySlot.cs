using UnityEngine;

namespace InventorySystem
{
    public class InventorySlot : MonoBehaviour
    {
        public RectTransform SlotTransform { get; private set; }
        public bool IsLocked { get; private set; }
    }
}
