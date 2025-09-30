using UnityEngine;

public class GridSpawner : MonoBehaviour
{
    public GameObject prefab;
    public int rows = 5;
    public int columns = 5;
    public float cellSize = 1f;

    void Start()
    {
        for (int x = 0; x < columns; x++)
        {
            for (int y = 0; y < rows; y++)
            {
                Vector3 position = new Vector3(x * cellSize, y * cellSize, 0);
                Instantiate(prefab, position, Quaternion.identity, transform);
            }
        }
    }
}