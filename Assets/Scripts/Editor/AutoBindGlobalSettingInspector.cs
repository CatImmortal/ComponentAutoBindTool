﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(AutoBindGlobalSetting))]
public class AutoBindGlobalSettingInspector : Editor
{
    private SerializedProperty m_Namespace;
    private SerializedProperty m_CodePath;

    private void OnEnable()
    {
        m_Namespace = serializedObject.FindProperty("m_Namespace");
        m_CodePath = serializedObject.FindProperty("m_CodePath");
    }

    public override void OnInspectorGUI()
    {
       
        m_Namespace.stringValue = EditorGUILayout.TextField(new GUIContent("默认命名空间"), m_Namespace.stringValue);

        EditorGUILayout.LabelField("默认代码保存路径：");
        EditorGUILayout.LabelField(m_CodePath.stringValue);
        if (GUILayout.Button("选择路径", GUILayout.Width(140f)))
        {
            m_CodePath.stringValue = EditorUtility.OpenFolderPanel("选择代码保存路径", Application.dataPath, "");
        }

        serializedObject.ApplyModifiedProperties();
       
    }
}
