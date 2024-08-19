using UnityEngine;
using UnityEngine.UI;

namespace InventorySystem
{
    public class InventorySlot : MonoBehaviour
    {
        public Image HighlightImage { get; private set; }
        public RectTransform SlotTransform { get; private set; }
        public bool IsEmpty { get; private set; }

        public void Highlight(Color color)
        {
            HighlightImage.color = color;
        }

        public void ClearHighlight()
        {
            HighlightImage.color = Color.white;
        }
    }
}
