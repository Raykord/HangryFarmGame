using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
	public PlayerHpManager player;
	public Animator reastartButton;
	public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
	
	private void Update()
	{
		if (player.isDead)
		{
			reastartButton.SetBool("isHidden", false);
		}
		if (!player.isDead)
		{
			reastartButton.SetBool("isHidden", true);
		}
	}
}
