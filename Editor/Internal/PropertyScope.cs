﻿using System;
using UnityEditor;
using UnityEngine;

namespace Toolbox.Editor.Internal
{
    /// <summary>
    /// Mirrors functionality of the <see cref="EditorGUI.PropertyScope"/> for layout-based controls.
    /// Additionally creates foldout label for the given property.
    /// </summary>
    internal class PropertyScope : IDisposable
    {
        private readonly SerializedProperty property;

        public PropertyScope(SerializedProperty property, GUIContent label)
        {
            this.property = property;
            var rowHeight = EditorGUIUtility.singleLineHeight;
            var rect = EditorGUILayout.GetControlRect(true, rowHeight);
            label = EditorGUI.BeginProperty(rect, label, property);
            property.isExpanded = EditorGUI.Foldout(rect, property.isExpanded, label, true);
        }

        public void Dispose()
        {
            EditorGUI.EndProperty();
        }

        public bool IsVisible => property.isExpanded;
    }
}
