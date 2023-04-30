using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerRotation : MonoBehaviour
{
	public Transform target;
	Quaternion rotation;

	private void Start()
	{
		
	}
	void Update()
	{

		Vector3 mousePosition = Input.mousePosition;
		Vector3 targetPosition = Camera.main.ScreenToWorldPoint(mousePosition);
		float tempX = transform.eulerAngles.x;

		//Quaternion rotation = Quaternion.LookRotation(relativePos);
		//transform.rotation = rotation;
		transform.LookAt(targetPosition, Vector3.up);
		transform.eulerAngles = new Vector3(tempX, transform.eulerAngles.y, transform.eulerAngles.z);
		//Quaternion rotation = Quaternion.Euler(0, transform.rotation.y, 0);
		//transform.rotation = rotation;
	}
}
