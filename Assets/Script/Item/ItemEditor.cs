using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEditor;
using UnityEditor.TerrainTools;
using UnityEngine;


[CustomEditor(typeof(ItemData))]
public class ItemEditor : Editor
{

    private SerializedProperty _name;
    private SerializedProperty _typeOfItem;
    private SerializedProperty _description;

    private GUIStyle _sectionLabel;
    private GUIStyle _titleLabel;
    private void OnEnable()
    {
        _titleLabel = new GUIStyle();
        _titleLabel.fontSize = 18;
        _titleLabel.fontStyle = FontStyle.Bold;
        _titleLabel.alignment = TextAnchor.MiddleCenter;
        _titleLabel.normal.textColor = Color.white;

        _sectionLabel = new GUIStyle();
        _sectionLabel.fontSize = 14;
        _sectionLabel.fontStyle = FontStyle.Bold;
        _sectionLabel.alignment = TextAnchor.MiddleCenter;
        _sectionLabel.normal.textColor = Color.white;

        //general
        _name = serializedObject.FindProperty("_name");
        _typeOfItem = serializedObject.FindProperty("_typeOfItem");
        _description = serializedObject.FindProperty("_description");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.UpdateIfRequiredOrScript();
        EditorGUILayout.LabelField(_name.stringValue.ToUpper(), _titleLabel);
        EditorGUILayout.Space(10);

        EditorGUILayout.LabelField("General Stats", _sectionLabel);
        EditorGUILayout.Space(5);

        EditorGUILayout.PropertyField(_name, new GUIContent("Name"));
        if (_name.stringValue == string.Empty)
        {
            EditorGUILayout.HelpBox("Caution: No name specified. Please name the entity!", MessageType.Warning);
        }

        EditorGUILayout.PropertyField(_typeOfItem, new GUIContent("Item type"));
        EditorGUILayout.PropertyField(_description, new GUIContent("Description"));

    }
}
