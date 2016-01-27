using UnityEngine;
using UnityEngine.UI;

public class ShapeSwitcher : MonoBehaviour {

    public Text text;
    public Mesh[] meshes;
    public GameObject meshObject;
    private int shapeIndex = 0;

    public void TextUpdater()
    {
        text.text = (meshes[shapeIndex].ToString());
    }

    public void ShapeSwitcherLeft() {
        shapeIndex--;
        if (shapeIndex < 0)
        {
            shapeIndex = meshes.Length - 1;
        }
        meshObject.GetComponent<MeshFilter>().sharedMesh = meshes[shapeIndex];
        text.text = (meshes[shapeIndex].ToString());
    }

    public void ShapeSwitcherRight() {
        shapeIndex++;
        if (shapeIndex > meshes.Length - 1)
        {
            shapeIndex = 0;
        }
        meshObject.GetComponent<MeshFilter>().sharedMesh = meshes[shapeIndex];
        text.text = (meshes[shapeIndex].ToString());
    }
    
}
