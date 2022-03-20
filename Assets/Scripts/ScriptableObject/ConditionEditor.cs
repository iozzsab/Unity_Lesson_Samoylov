using UnityEditor;
using UnityEngine;

[CustomEditor (typeof (Condition))]
public class ConditionEditor : Editor 
{
    public override void OnInspectorGUI()
    {
        Condition condition = (Condition) target;

        GUILayout.BeginHorizontal(GUI.skin.box);
            condition.description = GUILayout.TextField(condition.description);

        GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();

            GUILayout.Label ("isSatisfied");
            condition.isSatisfied = EditorGUILayout.Toggle(condition.isSatisfied);

        GUILayout.EndHorizontal ();
    }
}
