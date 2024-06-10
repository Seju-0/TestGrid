using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GridGenerator))]
public class GridGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        GridGenerator gridGenerator = (GridGenerator)target;
        if (GUILayout.Button("Generate Grid"))
        {
            gridGenerator.GenerateGrid();
        }
        if (GUILayout.Button("Delete Grid"))
        {
            gridGenerator.ClearGrid();
        }
    }
    [MenuItem("Tools/Generate Grid")]

    public static void GenerateGridMenu()
    {
        GridGenerator gridGenerator = FindObjectOfType<GridGenerator>();
        if (gridGenerator != null) 
        {
            gridGenerator.GenerateGrid();        
        }
        else
        {
            Debug.LogError("No Grid Generator Found in Scene");
        }
    }
}
