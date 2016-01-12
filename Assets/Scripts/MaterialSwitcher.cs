using UnityEngine;
using UnityEngine.UI;

public class MaterialSwitcher : MonoBehaviour {

    public Text text;
    public Material[] materials;
    public GameObject texturedObject;
    private int materialIndex = 0;

    public void MaterialSwitcherLeft()
    {
        materialIndex--;
        if (materialIndex < 0)
        {
            materialIndex = materials.Length - 1;
        }
        texturedObject.GetComponent<Renderer>().sharedMaterial = materials[materialIndex];
        text.text = (materials[materialIndex].ToString());
    }

    public void MaterialSwitcherRight()
    {
        materialIndex++;
        if (materialIndex > materials.Length - 1)
        {
            materialIndex = 0;
        }
        texturedObject.GetComponent<Renderer>().sharedMaterial = materials[materialIndex];
        text.text = (materials[materialIndex].ToString());
    }

}
