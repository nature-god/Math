using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineManager : MonoBehaviour {

	public Vector3 StartPoint;
	public Vector3 EndPoint;

	public Vector2 GetVector()
	{
		float x = StartPoint.x - EndPoint.x;
		float y = StartPoint.y - EndPoint.y;
		return new Vector2(x,y);
	}
}
