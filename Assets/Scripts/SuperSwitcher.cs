using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class SuperSwitcher : MonoBehaviour
{

    public Text text;

    public List<GameObject> toys;
    private GameObject toyOn;
    private int toyIndex = 0;
    //public Material[] materials;
    //public GameObject texturedObject;
    //private int materialIndex = 0;

    public void GameObjectSwitcherLeft()
    {
        toyIndex--;
        if (toyIndex < 0)
        {
            toyIndex = toys.Count - 1;
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

    public void GameObjectSwitcherRight()
    {
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

    //public void MaterialSwitcherLeft()
    //{
    //    materialIndex--;
    //    if (materialIndex < 0)
    //    {
    //        materialIndex = materials.Length - 1;
    //    }
    //    texturedObject.GetComponent<Renderer>().sharedMaterial = materials[materialIndex];
    //    text.text = (materials[materialIndex].ToString());
    //}

    //public void MaterialSwitcherRight()
    //{
    //    materialIndex++;
    //    if (materialIndex > materials.Length - 1)
    //    {
    //        materialIndex = 0;
    //    }
    //    texturedObject.GetComponent<Renderer>().sharedMaterial = materials[materialIndex];
    //    text.text = (materials[materialIndex].ToString());
    //}

}
