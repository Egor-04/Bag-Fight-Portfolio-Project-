using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace InventorySystem
{
    public class Cell : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        private bool IsEmpty;
        private Image HighlightImage;
        private RectTransform SlotTransform;

        private int _x;
        private int _y;
        private TetrisInventory _inventory;

        private void Start()
        {
            HighlightImage = GetComponent<Image>();
        }

        public void Highlight(Color color)
        {
            HighlightImage.color = color;
        }

        public void SetCellParameters(TetrisInventory inventory, bool isEmpty, params int[] size)
        {
            _inventory = inventory;
            _x = size[0];
            _y = size[1];
            IsEmpty = isEmpty;
        }

        public void ClearHighlight()
        {
            HighlightImage.color = Color.white;
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            HighlightImage.color = Color.green;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            HighlightImage.color = Color.white;
        }
    }
}
