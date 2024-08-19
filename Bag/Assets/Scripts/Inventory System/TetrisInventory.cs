using UnityEngine;
using TMPro;

namespace InventorySystem
{
    public class TetrisInventory : MonoBehaviour
    {
        [SerializeField] private DragDrop _dragDropContainer;
        [SerializeField] private Transform _itemsContainer;

        private void Start()
        {
            Grid grid = new Grid(10, 5, 5f);
        }

        public void SetItemAsChildToItemContainer(GameObject gameObject)
        {
            gameObject.transform.SetParent(_itemsContainer);
        }
    }
}