﻿using Toolbox.Editor.Internal;
using UnityEditor;
using UnityEngine;

namespace Toolbox.Editor.Drawers
{
    public class Vector2Drawer : BaseMaterialPropertyDrawer
    {
        protected override float GetPropertyHeightSafe(MaterialProperty prop, string label, MaterialEditor editor)
        {
            return EditorGUIUtility.singleLineHeight;
        }

        protected override void OnGUISafe(Rect position, MaterialProperty prop, string label, MaterialEditor editor)
        {
            using (new FixedFieldsScope())
            {
                EditorGUIUtility.labelWidth = 0;

                var vectorValue = prop.vectorValue;
                EditorGUI.BeginChangeCheck();
                vectorValue = EditorGUI.Vector2Field(position, label, vectorValue);
                if (EditorGUI.EndChangeCheck())
                {
                    prop.vectorValue = vectorValue;
                }
            }
        }

        protected override bool IsPropertyValid(MaterialProperty prop)
        {
            return prop.type == MaterialProperty.PropType.Vector;
        }
    }
}