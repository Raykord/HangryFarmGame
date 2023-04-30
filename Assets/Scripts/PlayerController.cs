using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float xRange = 15.0f;
	public float zRangeMax = 15.0f;
	public float zRangeMin = 0;
	public GameObject cookie;
	public GameObject cookieSpawnPosition;
	public Camera cam;
	public Rigidbody rb;

    private float horizontalInput;
	private float verticalInput;
	private Vector3 mousePos;
	private Quaternion m_MyQuaternion;
	// Start is called before the first frame update
	void Start()
    {
		m_MyQuaternion = new Quaternion();
	}

    // Update is called once per frame
    void Update()
    {
		mousePos = cam.ScreenToWorldPoint(UnityEngine.Input.mousePosition) - rb.position;
		//Правая и левая граница перемещения
		if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
		if (transform.position.x > xRange)
		{
			transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
		}
		if (transform.position.z < -zRangeMin)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y, zRangeMin);
		}
		if (transform.position.z > zRangeMax)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y, zRangeMax);
		}
		horizontalInput = UnityEngine.Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime, Space.World);
		verticalInput = UnityEngine.Input.GetAxis("Vertical");
		transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime, Space.World);

		

        
		if (UnityEngine.Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(cookie, cookieSpawnPosition.transform.position, transform.rotation);
        }
    }

	private void FixedUpdate()
	{
		//Vector3 lookDir = mousePos - rb.position;
		//float angle = Mathf.Atan2(lookDir.z, lookDir.x) * Mathf.Rad2Deg - 90f;
		//m_MyQuaternion = Quaternion.AngleAxis(-angle, Vector3.up);

		//rb.rotation = m_MyQuaternion;
	}

	private void OnTriggerEnter(Collider other)
	{
        
	}
}
