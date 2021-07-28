﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.Linq;

[ExecuteInEditMode]
public class CustomTerrain : MonoBehaviour
{   
    public Vector2 randomHeightRange = new Vector2(0,0.1f);

    public void RandomTerrain(){
        
    }


    private void Awake() {
        SerializedObject tagManager = new SerializedObject(AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/TagManager.asset")[0]);
        SerializedProperty tagsProp = tagManager.FindProperty("tags");

        AddTag(tagsProp,"Terrain");
        AddTag(tagsProp,"Cloud");
        AddTag(tagsProp,"Shore");
        AddTag(tagsProp,"LandBorder");
        tagManager.ApplyModifiedProperties();

        this.gameObject.tag ="Terrain";
    }
    void AddTag(SerializedProperty tagsProp, string newTag){
        bool found = false;
        for(int i=0;i< tagsProp.arraySize;i++){
            SerializedProperty t = tagsProp.GetArrayElementAtIndex(i);
            if(t.stringValue.Equals(newTag)){found = true;break;}
        }

        if(!found){
            tagsProp.InsertArrayElementAtIndex(0);
            SerializedProperty newTagProp = tagsProp.GetArrayElementAtIndex(0);
            newTagProp.stringValue = newTag;        
        }
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
