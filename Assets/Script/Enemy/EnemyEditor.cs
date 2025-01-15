using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.TerrainTools;

[CustomEditor(typeof(EnemyData))]
public class EnemyEditor : Editor
{
    private SerializedProperty _name;
    private SerializedProperty _typeOfEnemy;
    private SerializedProperty _animator;
    private SerializedProperty _animatorController;
    private SerializedProperty _sprite;

    private SerializedProperty _speed;
    private SerializedProperty _life;
    private SerializedProperty _damage;
    private SerializedProperty _dropChance;

    private SerializedProperty _range;
    private SerializedProperty _aggresivness;


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
        _typeOfEnemy = serializedObject.FindProperty("_typeOfItem");
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
        EditorGUILayout.PropertyField(_typeOfEnemy, new GUIContent("Enemy type"));
        
    }
}
