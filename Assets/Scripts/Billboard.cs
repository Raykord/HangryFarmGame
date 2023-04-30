using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Billboard : MonoBehaviour
{
    public GameObject camera;

	private void Start()
	{
		camera = GameObject.Find("Main Camera");
	}
	// Update is called once per frame
	void LateUpdate()
    {
        transform.LookAt(transform.position + camera.transform.forward);
    }
}
