using UnityEngine;
using TMPro;

namespace InventorySystem
{
    public class TetrisInventory : MonoBehaviour
    {
        [SerializeField] private int _width;
        [SerializeField] private int _height;
        [SerializeField] private Cell _cellPrefab;
        [SerializeField] private Transform _itemsContainer;
        [SerializeField] private DragDrop _dragDropContainer;
        [SerializeField] private Cell[,] _allCells;

        private void Start()
        {
            CreateInventoryGrid();
        }

        private void CreateInventoryGrid()
        {
            _allCells = new Cell[_width, _height];
            
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    var newCell = Instantiate(_cellPrefab, _itemsContainer);
                    newCell.name = x + " : " + y;
                    newCell.SetCellParameters(this, true, x, y);
                    _allCells[x, y] = newCell;
                }
            }
        }

        public void SetItemAsChildToItemContainer(GameObject gameObject)
        {
            gameObject.transform.SetParent(_itemsContainer);
        }
    }
}