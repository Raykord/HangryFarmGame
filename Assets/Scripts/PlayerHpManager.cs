using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerHpManager : MonoBehaviour
{
	public int maxHealth = 150;
	public HealthBar healthBar;
	public bool isDead;

	private int currenthealth;
	// Start is called before the first frame update
	void Start()
    {
		isDead = false;
		currenthealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
	}

    // Update is called once per frame
    void Update()
    {
		if (currenthealth <= 0)
		{
			isDead = true;
			Destroy(gameObject);
		}
	}

	private void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "Cow")
		{
			TakeDamge(50);
		}
		if (collider.gameObject.tag == "Horse")
		{
			TakeDamge(30);
		}
		if (collider.gameObject.tag == "Chiken")
		{
			TakeDamge(10);
		}
	}

	void TakeDamge(int damge)
	{
		currenthealth -= damge;
		healthBar.SetHealth(currenthealth);
	}
}
