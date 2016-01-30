using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(InteractFunctionality))]
public class InteractFunctionalityEditor : Editor {

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        InteractFunctionality interactFunctionalityScript = (InteractFunctionality)target;
        interactFunctionalityScript.interactableTag = EditorGUILayout.TagField("Interactable Tag", interactFunctionalityScript.interactableTag);
    }
}
