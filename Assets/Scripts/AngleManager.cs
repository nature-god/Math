using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AngleManager : MonoBehaviour {

	public LineManager CrossLine1;
	public LineManager CrossLine2;

	public Image AngleImage;

	public float angle;
	public Vector3 CrossPoint;
	// Use this for initialization
	//(x-x1)(y2-y1) = (y-y1)(x2-x1)
	//(y2-y1)x+(x1-x2)y+y1(x2-x1)-x1(y2-y1) = 0
	//Ax+By+C = 0
	void Start () {
		Vector2 VectorLine1 = CrossLine1.GetVector();
		Vector2 VectorLine2 = CrossLine2.GetVector();
		float angleCos = ((VectorLine1.x*VectorLine2.x+VectorLine1.y*VectorLine2.y)/(Mathf.Sqrt(VectorLine1.x*VectorLine1.x+VectorLine1.y*VectorLine1.y)*Mathf.Sqrt(VectorLine2.x*VectorLine2.x+VectorLine2.y*VectorLine2.y)));

		angle = Mathf.Acos(angleCos)*180.0f/Mathf.PI;
		Debug.Log("angleCos: " + angleCos+"   angle: "+angle);
	}
}
