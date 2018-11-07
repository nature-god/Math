using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineManager : MonoBehaviour {
	
	public PointManager StartPoint;
	public PointManager EndPoint;
	public Line line;
	
	public void DrawLine()
	{
		StartPoint.DrawPoint();
		EndPoint.DrawPoint();
		line = new Line(StartPoint.point,EndPoint.point);
		this.transform.localPosition = line.GetPosition();
		this.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(line.GetLength(),1);
		this.transform.GetComponent<RectTransform>().localRotation = Quaternion.Euler(new Vector3(0,0,line.GetRotate()));
		this.transform.name = line.GetName();
		this.gameObject.AddComponent<BoxCollider>().size = new Vector3(line.GetLength(),1.0f,1.0f);
	}
}
