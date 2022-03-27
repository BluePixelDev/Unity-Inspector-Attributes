using UnityEngine;
using UnityEditor;

public class Divider : PropertyAttribute
{
	public float height;

	public Divider(float height = 2) 
	{
		this.height = height;
	}
}

#if UNITY_EDITOR
[CustomPropertyDrawer(typeof(Divider))]
public class DividerDrawer : DecoratorDrawer
{
	Divider divider 
	{
		get { return ((Divider)attribute); }
	}

	//Returns height of the property
	public override float GetHeight()
	{
		return base.GetHeight() + divider.height / 2;
	}

	//Draws the divider
	public override void OnGUI(Rect position)
	{
		float lineY = position.y + (divider.height / 2);
		GUI.DrawTexture(new Rect(position.x, lineY, position.width, divider.height), Texture2D.grayTexture);
	}

}
#endif
