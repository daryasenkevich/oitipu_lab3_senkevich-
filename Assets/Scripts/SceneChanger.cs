using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
	public void ChangeToLevel1()
	{
		SceneManager.LoadScene("level1");
	}
	public void ChangeToMain()
	{
		SceneManager.LoadScene("main");
	}
	public void ChangeToLevel2()
	{
		SceneManager.LoadScene("level2");
	}

}