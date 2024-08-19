using UnityEngine;

public class Grid
{
    private int _width;
    private int _height;
    private float _cellSize;
    private int[,] _gridArray;


    public Grid(int width, int height, float cellSize)
    {
        _width = width;
        _height = height;
        _cellSize = cellSize;

        _gridArray = new int[width, height];

        for (int x = 0; x < _gridArray.GetLength(0); x++)
        {
            for (int y = 0; y < _gridArray.GetLength(1); y++)
            {
                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x, y + 1), Color.green, 100f);
                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x + 1, y), Color.green, 100f);
            }
        }

        Debug.DrawLine(GetWorldPosition(0, height), GetWorldPosition(width, height), Color.green, 100f);
        Debug.DrawLine(GetWorldPosition(width, 0), GetWorldPosition(width, height), Color.green, 100f);
    }

    private Vector3 GetWorldPosition(int x, int y)
    {
        return new Vector3(x, y) * _cellSize;
    }
}