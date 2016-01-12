using UnityEngine;

public class GroundSwitcher : MonoBehaviour {

    public Material[] materials;
    public GameObject texturedObject;
    private int materialIndex = 0;    

	//void Start () {
 //       texturedObject.GetComponent<Renderer>().sharedMaterial = materials[index];          
 //   }

	public void OnGUI () {
        GUILayout.BeginArea (new Rect(Screen.width / 2 - 100, Screen.height / 8 + 20, 200, 50));

        GUI.Label (new Rect(90, 20, 100, 20), materials[materialIndex].ToString());

        if (GUI.Button(new Rect(15, 15, 30, 30), "<<")) {
            materialIndex--;
            if (materialIndex < 0) {
                materialIndex = materials.Length - 1;
            }
            texturedObject.GetComponent<Renderer>().sharedMaterial = materials[materialIndex];
        }

        if (GUI.Button(new Rect(55, 15, 30, 30), ">>")) {
            materialIndex++;
            if (materialIndex > materials.Length - 1) {
                materialIndex = 0;
            }
            texturedObject.GetComponent<Renderer>().sharedMaterial = materials[materialIndex];
        }

        GUILayout.EndArea ();
	}
}
