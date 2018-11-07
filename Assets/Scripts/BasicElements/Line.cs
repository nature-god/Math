using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line {
	public Point[] Points;

	public Line(){}
	public Line(Point Start,Point End)
	{
		Points = new Point[2];
		Points[0] = Start;
		Points[1] = End;
	}

	public string GetName()
	{
		return Points[0].Name+Points[1].Name;
	}

	public float GetLength()
	{
		float tmp_x = 0.0f;
		float tmp_y = 0.0f;
		tmp_x = Points[0].Position.x-Points[1].Position.x;
		tmp_y = Points[0].Position.y-Points[1].Position.y;
		return Mathf.Sqrt(tmp_x*tmp_x+tmp_y*tmp_y);
	}

	public Vector3 GetPosition()
	{
		float tmp_x = Points[0].Position.x + Points[1].Position.x;
		float tmp_y = Points[0].Position.y + Points[1].Position.y;
		float tmp_z = Points[0].Position.z + Points[1].Position.z;
		return new Vector3(tmp_x/2,tmp_y/2,tmp_z/2);
	}

	public float GetRotate()
	{
		if(Points[0].Position.x == Points[1].Position.x)
		{
			return 90.0f;
		}
		else
		{
			Vector2 tmp = new Vector2(-1.0f,0);
			Vector2 VectopTmp = new Vector2(Points[1].Position.x-Points[0].Position.x,Points[1].Position.y-Points[0].Position.y);
			float mul = tmp.x*VectopTmp.x+tmp.y*VectopTmp.y;
			return Mathf.Acos(mul/VectopTmp.magnitude)*180.0f/Mathf.PI;
		}
	}
}
