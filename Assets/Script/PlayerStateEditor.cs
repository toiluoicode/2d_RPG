using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(PlayerStatus))]
public class PlayerStateEditor : Editor
{
    private PlayerStatus status => target as PlayerStatus;
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("Reset Player"))
        {
            status.ResetPlayer();
        }
    }
}
