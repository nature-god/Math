using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angle{
	public Point[] Points;

	public Angle(){}
	public Angle(Point _point1,Point _point2,Point _point3)
	{
		Points = new Point[3];
		Points[0] = _point1;
		Points[1] = _point2;
		Points[2] = _point3;
	}
	public string GetName()
	{
		return Points[0].Name+Points[1].Name+Points[2].Name;
	}
	public float GetAngle()
	{
		//Use Cos to get
		Line line01 = new Line(Points[0],Points[1]);
		Line line21 = new Line(Points[2],Points[1]);
		float tmp = (Points[1].Position.x - Points[0].Position.x)*(Points[1].Position.x - Points[2].Position.x) + 
					(Points[1].Position.y - Points[0].Position.y)*(Points[1].Position.y - Points[2].Position.y);
		float angleCos = tmp/(line01.GetLength()*line21.GetLength());
		return Mathf.Acos(angleCos)*180.0f/Mathf.PI;
	}
}
