using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {


	public void LoadLevel (string name) {

        SceneManager.LoadScene(name);

	}
	

}
