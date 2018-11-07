using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AngleManager : MonoBehaviour {

	public PointManager StartPoint;
	public PointManager MidPoint;
	public PointManager EndPoint;

	public Angle angle;

	void ShowAngle()
	{
		angle = new Angle(StartPoint.point,MidPoint.point,EndPoint.point);
	}

}
