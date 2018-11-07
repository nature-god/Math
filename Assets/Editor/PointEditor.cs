using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PointManager))]
public class PointEditor : Editor {
	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();

		PointManager tmp = (PointManager)target;
		if(GUILayout.Button("Draw Point"))
		{
			tmp.DrawPoint();
		}
	}

}
