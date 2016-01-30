using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(HealthFunctionality))]
public class NewBehaviourScript : Editor {

    public override void OnInspectorGUI()
    {
        HealthFunctionality healthFunctionalityScript = (HealthFunctionality)target;
        DrawDefaultInspector();
        healthFunctionalityScript.setTotalHealth(EditorGUILayout.Slider(healthFunctionalityScript.getTotalHealth(), 0, healthFunctionalityScript.getMaxHealth()));
    }

}
