using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneNew : MonoBehaviour
{
	public void ChangeToLevel()
	{
		SceneManager.LoadScene("level1");
	}
}
