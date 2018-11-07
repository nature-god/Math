using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LineManager))]
public class LineEditor : Editor {

	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();

		LineManager tmp = (LineManager)target;

		if(GUILayout.Button("Draw Line"))
		{
			tmp.DrawLine();
		}
	}
}
