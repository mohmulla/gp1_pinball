// Copyright by #Team1 2025. All rights reserved. 

using Unity.VisualScripting;
using UnityEngine;

public class springu : MonoBehaviour
{
	// components
	Rigidbody2D body;

	Vector2 restPosition;

	float firstLevel = -1f;
	float secondLevel = -2f;
	float thirdLevel = -3f;

	[SerializeField] float addedVelocity = 0f;

	 // Start is called once before the first execution of Update after the MonoBehaviour is created
	 void Start()
	 {
		body = GetComponent<Rigidbody2D>();

		restPosition = transform.position;
	 }

	 // Update is called once per frame
	 void Update()
	 {
		MoveSpring();
	 }

	private void MoveSpring()
	{
		if ( Input.GetKey(KeyCode.Space) )
		{
			body.linearVelocity = new Vector2(0f, -1f);
		}
		else
		{
			body.linearVelocity = new Vector2(0f, addedVelocity);
		}

		if (restPosition.y - transform.position.y > firstLevel )
		{
			addedVelocity = -firstLevel;
		}
		if ( restPosition.y - transform.position.y > secondLevel )
		{
			addedVelocity = -secondLevel;
		}
		if (restPosition.y - transform.position.y > thirdLevel)
		{
			addedVelocity = -thirdLevel;
		}

	}

}
