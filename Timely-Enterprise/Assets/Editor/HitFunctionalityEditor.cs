using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(HitFunctionality))]
public class HitFunctionalityEditor : Editor {

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        HitFunctionality hitFunctionalityScript = (HitFunctionality)target;
        hitFunctionalityScript.hittableTag = EditorGUILayout.TagField("Hittable Tag", hitFunctionalityScript.hittableTag);
    }

}
