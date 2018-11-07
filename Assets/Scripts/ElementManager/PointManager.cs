using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class PointManager : MonoBehaviour {

	public string Name;
	public Vector3 Position;
	public Point point;
	public TextDirection textDirection;
	public enum TextDirection
	{
		Up,
		Right,
		Left,
		Down
	};

	public void DrawPoint() {
		point = new Point(Name,Position);
		this.transform.localPosition = Position;
		this.transform.name = Name;
		this.transform.GetChild(0).GetComponent<Text>().text = Name;
		switch (textDirection)
		{
			case TextDirection.Left:
			{
				this.transform.GetChild(0).localPosition = new Vector3(-20.0f,0.0f,0.0f);
				break;
			}
			case TextDirection.Right:
			{
				this.transform.GetChild(0).localPosition = new Vector3(20.0f,0.0f,0.0f);
				break;
			}
			case TextDirection.Up:
			{
				this.transform.GetChild(0).localPosition = new Vector3(0.0f,20.0f,0.0f);
				break;
			}
			case TextDirection.Down:
			{
				this.transform.GetChild(0).localPosition = new Vector3(0.0f,-20.0f,0.0f);
				break;
			}
			default:
			{
				Debug.Log("No valid textDirection!");
				break;
			}
		}
	}
}
