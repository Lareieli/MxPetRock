using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class SuperSwitchLeft : MonoBehaviour
{

    public Text text;
    public List<GameObject> toys;
    private GameObject toyOn;
    private int toyIndex = 0;

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            GameObjectSwitcher();
        }
    }

    public void GameObjectSwitcher()
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

}
