using UnityEngine;
using UnityEditor;

public class Label : PropertyAttribute
{
	public string content;
	public GUIStyle style;

	#region Constructors
	public Label(string content) 
	{
		this.content = content;
	}

	public Label(string content, GUIStyle style)
	{
		this.content = content;
		this.style = style;
	}	
	#endregion
}

#if UNITY_EDITOR
[CustomPropertyDrawer(typeof(Label))]
public class LabelDrawer : DecoratorDrawer
{
	private int size = 10;
	GUIStyle style;

	Label label 
	{
		get { return ((Label)attribute); }
	}

	//Returns height of the properrty
	public override float GetHeight()
	{
		//Setting up the style
		style = new GUIStyle(label.style ?? GUI.skin.label);
		style.fontStyle = FontStyle.BoldAndItalic;
		style.fontSize = size;

		return base.GetHeight() + style.lineHeight / 2;
	}

	//Draws the property
	public override void OnGUI(Rect position)
	{
		if(label.style != null) 
		{
			label.style.fontSize = size;
			GUI.Label(position, label.content, label.style);
		}
		else 
		{		
			GUI.Label(position, label.content, style);
		}
			
	}
}
#endif
