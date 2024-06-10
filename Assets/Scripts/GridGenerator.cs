using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public int width, height;
    public GameObject tilePrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateGrid()
    {
        if(tilePrefab == null) 
        {
            Debug.LogError("No Prefab Assigned");
            return;
        }
        for (int x = 0; x < width ; x++) 
        {
            for (int y = 0; y < height; y++)
            {
                Vector3 position = new Vector3(x, 0, y);
                GameObject newTile = Instantiate(tilePrefab,position,Quaternion.identity);
                newTile.transform.parent = transform;
                newTile.tag = "Tile";
            }
        }
    }
    public void ClearGrid()
    {
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");
        foreach (GameObject tile in tiles) 
        { 
            DestroyImmediate(tile);
        }
    }
}
