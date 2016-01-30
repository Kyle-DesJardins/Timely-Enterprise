using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(KickFunctionality))]
public class KickFunctionalityEditor : Editor {

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        KickFunctionality kickFunctionalityScript = (KickFunctionality)target;
        kickFunctionalityScript.kickableTag = EditorGUILayout.TagField("Kickable Script", kickFunctionalityScript.kickableTag);
    }


}
