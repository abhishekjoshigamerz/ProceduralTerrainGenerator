using UnityEditor;
using UnityEngine;
using EditorGUITable;

[CustomEditor(typeof(CustomTerrain))]
[CanEditMultipleObjects]
public class CustomTerrainEditor : Editor
{
    SerializedProperty randomHeightRange;
    void OnEnable() 
    {
        randomHeightRange  = SerializedObject.FindProperty("randomHeightRange");
    }
    
    public override void OnInspectorGUI()
    {
        SerializedObject.Update();
        
        CustomTerrain terrain = (CustomTerrain) target;

        terrain.randomHeightRange = 

        SerializedObject.ApplyModifiedProperties();    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
