using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

	public float speed = 6.0f;
	public float jumpForce = 8.0f;
	public float gravity = 20.0f;


	private Vector3 moveDirection = Vector3.zero;

	void Update()
	{

		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded)
		{
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			if (Input.GetButton("Jump"))
			{
				moveDirection.y = jumpForce;

			}
		}
	}
}
