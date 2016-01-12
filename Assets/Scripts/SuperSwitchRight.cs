using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class SuperSwitchRight : MonoBehaviour {

    public Text text;

    public List<GameObject> toys;
    private GameObject toyOn;
    private int toyIndex = 0;

    public void GameObjectSwitcherRight() {

        toyIndex++;
        if (toyIndex > toys.Count - 1)
        {
            toyIndex = 0;
        }
        toyOn = toys[toyIndex];
        toyOn.gameObject.SetActive(true);
        for (var i = 0; i < toys.Count; i++)
        {
            if (i != toyIndex)
            {
                toys[i].SetActive(false);
            }
        }
        text.text = (toys[toyIndex].ToString());
    }

    public Material[] materials;
    public GameObject texturedObject;
    private int materialIndex = 0;

    public void TextureSwitcherRight() {
        
        materialIndex++;
        if (materialIndex > materials.Length - 1)
        {
            materialIndex = 0;
        }
        texturedObject.GetComponent<Renderer>().sharedMaterial = materials[materialIndex];
        text.text = (materials[materialIndex].ToString());

    }	
	
}
