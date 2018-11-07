using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point{

	public string Name;
	public Vector3 Position;

	public Point(){}
	public Point(string _name,Vector3 _position)
	{
		Name = _name;
		Position = _position;
	}
}
