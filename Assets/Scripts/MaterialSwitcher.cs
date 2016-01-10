using UnityEngine;

public class MaterialSwitcher : MonoBehaviour {

    public Material[] materials;
    public GameObject texturedObject;
    private int index = 0;   

	//void Start () {
 //       texturedObject.GetComponent<Renderer>().sharedMaterial = materials[index];        
 //   }

	public void OnGUI () {
        GUILayout.BeginArea (new Rect(Screen.width / 2 - 100, Screen.height / 8 + 60, 200, 50));       

        GUI.Label (new Rect(90, 20, 100, 20), materials[index].ToString());

        if (GUI.Button(new Rect(15, 15, 30, 30), "<<")) {
            index--;
            if (index < 0) {
                index = materials.Length - 1;
            }
            texturedObject.GetComponent<Renderer>().sharedMaterial = materials[index];
        }

        if (GUI.Button(new Rect(55, 15, 30, 30), ">>")) {
            index++;
            if (index > materials.Length - 1) {
                index = 0;
            }
            texturedObject.GetComponent<Renderer>().sharedMaterial = materials[index];
        }

        GUILayout.EndArea ();
	}
}
