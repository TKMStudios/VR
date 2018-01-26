using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class WhiteboadPen : VRTK_InteractableObject
{

	private VRTK_ControllerActions controllerActions;

	public WhiteboardScript WB;

	private RaycastHit touch;

	private bool lastTouch;

	private Quaternion lastAngle;


	// Use this for initialization
	void Start ()
	{

		this.WB = GameObject.Find("Whiteboard").GetComponent<WhiteboardScript>();
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		float tipHeight = transform.Find("Tip").transform.localScale.y;
		Vector3 tip = transform.Find("Tip").transform.position;

		if(lastTouch)
		{
			tipHeight *= 1.1f;
		}

		if(Physics.Raycast (tip, transform.up, out touch, tipHeight))
		{
			if(!(touch.collider.tag == "Whiteboard"))
			{
				return;
			}

			this.WB = touch.collider.GetComponent<WhiteboardScript>();
			controllerActions.TriggerHapticPulse(0.05f);

			this.WB.SetColor(Color.blue);
			this.WB.SetTouchPosition(touch.textureCoord.x, touch.textureCoord.y);
			this.WB.ToggleTouch(true);

			if (!lastTouch)
			{
				lastTouch = true;

				lastAngle = transform.rotation;
			}
		}
		else
		{
			this.WB.ToggleTouch(false);
			lastTouch = false;
		}

		if(lastTouch)
		{

			transform.rotation = lastAngle;

		}
	}

	public override void Grabbed(GameObject grabbingObject)
	{
		base.Grabbed(grabbingObject);
		controllerActions = grabbingObject.GetComponent<VRTK_ControllerActions>();
	}
}
