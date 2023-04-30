using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowScript : MonoBehaviour
{
    public int maxHealth = 150;
	public HealthBar healthBar;

	private int currenthealth;
    

    // Start is called before the first frame update
    void Start()
    {
        currenthealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (currenthealth <= 0)
        {
            Destroy(gameObject);
            AddScore.ScoreAdd();
        }
    }

	private void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "Cookie")
        {
            TakeDamge(50);
        }
	}

	void TakeDamge(int damge)
    {
        currenthealth -= damge;
        healthBar.SetHealth(currenthealth);
    }
}
