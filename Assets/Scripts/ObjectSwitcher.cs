using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ObjectSwitcher : MonoBehaviour {

    public Text text;
    public List<GameObject> toys;
    private GameObject toyOn;
    private int toyIndex = 0;

    public void TextUpdater()
    {
        text.text = (toys[toyIndex].ToString());
    }

    public void GameObjectSwitcherLeft() {
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

}
