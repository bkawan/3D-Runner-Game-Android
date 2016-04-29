using UnityEngine;
using System.Collections;
//using SystemEngine.SceneManagement;

public class MenuUI : MonoBehaviour {


	public void OnClickPlay(){
		//SceneManager.LoadScene("Game");
		Application.LoadLevel ("gamescene");
	}

	public void OnClickExit(){
		Application.Quit ();
	}
}
