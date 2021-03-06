﻿using UnityEngine;
using UnityEditor;

namespace JVDialogue
{
    [CustomEditor(typeof(Textbox))]
    public class TextboxEditor : Editor
    {
        // This editor is designed to be mostly read-only stats.
        // All editing should be done directly on the Dialogue object.
        private Textbox tb;

        private bool foldout = true;

        private void OnEnable()
        {
            tb = (Textbox)target;
        }

        public override void OnInspectorGUI()
        {
            EditorGUILayout.HelpBox("These values are intended as readonly.\nPlease select the parent Dialogue to change these values.", MessageType.Info);

            EditorGUILayout.Space(10);

            using (new GUILayout.VerticalScope(EditorStyles.helpBox))
            {
                foldout = EditorGUILayout.Foldout(foldout, "Characters", true);
                if (foldout)
                {
                    EditorGUI.indentLevel++;
                    for (int i = 0; i < tb.characters.Length; i++)
                    {
                        string displayString = (tb.characters[i] != null ? $"Slot {i}: {tb.characters[i].name} - {tb.characterEmotes[i]}" : $"Slot {i}: None") + $"-{ (tb.flipY[i] ? "" : " Not")} Fliped";

                        EditorGUILayout.LabelField(displayString);
                    }
                    EditorGUI.indentLevel--;
                }

                EditorGUILayout.Space(5);

                EditorGUILayout.LabelField($"Active Speaker: Slot {tb.activeCharacter}");
                EditorGUILayout.LabelField($"Has Background Sprite?: {tb.background != null}");
                if (tb.background != null)
                {
                    EditorGUILayout.LabelField($"Background color: #{ColorUtility.ToHtmlStringRGBA(tb.backgroundColor)}");
                }

                EditorGUILayout.Space(5);

                EditorGUILayout.LabelField("Textbox Text Contents", EditorStyles.boldLabel);
                using (new GUILayout.VerticalScope(EditorStyles.helpBox))
                {
                    EditorGUILayout.LabelField(tb.text, EditorStyles.wordWrappedLabel);
                }
            }
        }
    }
}
