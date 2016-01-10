using UnityEngine;

public class RockSwitcher : MonoBehaviour {

    public Mesh[] meshes;
    public GameObject meshObject;
    private int index = 0;

    //void Start() {
    //    meshObject.GetComponent<MeshFilter>().sharedMesh = meshes[index];
    //}

    public void OnGUI() {
        GUILayout.BeginArea(new Rect(Screen.width / 2 - 100, Screen.height / 8 -20, 200, 50));

        GUI.Label(new Rect(90, 20, 100, 20), meshes[index].ToString());

        if (GUI.Button(new Rect(15, 15, 30, 30), "<<")) {
            index--;
            if (index < 0)
            {
                index = meshes.Length - 1;
            }
            meshObject.GetComponent<MeshFilter>().sharedMesh = meshes[index];
        }

        if (GUI.Button(new Rect(55, 15, 30, 30), ">>")) {
            index++;
            if (index > meshes.Length - 1)
            {
                index = 0;
            }
            meshObject.GetComponent<MeshFilter>().sharedMesh = meshes[index];
        }

        GUILayout.EndArea();
    }
}
