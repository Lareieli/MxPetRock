using UnityEngine;
using System.Collections.Generic;

public class ToySwitcher : MonoBehaviour {

    public List<GameObject> toys;
    private GameObject toyOn;
    private int toyIndex = 0;

    public void OnGUI()
    {
        GUILayout.BeginArea(new Rect(Screen.width / 2 - 100, Screen.height / 8 - 60, 200, 50));

        GUI.Label(new Rect(90, 20, 100, 20), toys[toyIndex].ToString());


        if (GUI.Button(new Rect(15, 15, 30, 30), "<<"))
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
        }

        if (GUI.Button(new Rect(55, 15, 30, 30), ">>"))
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
        }

        GUILayout.EndArea();
    }



    //public List<Renderer> toys;    
    //private Renderer toyOn;

    //// toyIndex starts as 0 which is Bolo Hat
    //private int toyIndex = 0;


    //public void OnGUI() {
    //    GUILayout.BeginArea(new Rect(Screen.width / 2 - 100, Screen.height / 8 - 60, 200, 50));

    //    GUI.Label(new Rect(90, 20, 100, 20), toys[toyIndex].ToString());

    //    //if left button pressed
    //    if (GUI.Button(new Rect(15, 15, 30, 30), "<<")) {
    //        // subtract one from current toyIndex -- the location in the list we are working with --
    //        // (which starts as 0) and the result is now the new toyIndex.              
    //        toyIndex--;
    //        //Debug.Log(toyIndex);
    //        // now toyIndex, which used to be 0, becomes -1
    //        if (toyIndex < 0)
    //            // if -1 is smaller than 0, which it is
    //        {
    //            // toyIndex becomes the total number of list items, minus one
    //            // A list of 4 contains 0,1,2,3 so a list of 4 total items 
    //            // subtracting one, becomes the string 3 (the end of the list)
    //            toyIndex = toys.Count - 1;
    //            // so now toyIndex is 3
    //        }
    //        toyOn = toys[toyIndex];
    //        // list item 3 now becomes toyOn
    //        toyOn.enabled = true;
    //        // list item 3 renderer is enabled 
    //        for (var i = 0; i < toys.Count; i++)
    //        {
    //            if (i != toyIndex)
    //            {
    //                toys[i].enabled = false;
    //            }
    //        }
    //    }

    //    if (GUI.Button(new Rect(55, 15, 30, 30), ">>")) {
    //        toyIndex++;
    //        if (toyIndex > toys.Count - 1)
    //        {
    //            toyIndex = 0;
    //        }
    //        toyOn = toys[toyIndex];            
    //        toyOn.enabled = true;
    //        for (var i = 0; i < toys.Count; i++)
    //        {
    //            if (i != toyIndex)
    //            {
    //                toys[i].enabled = false;
    //            }
    //        }
    //    }

    //    GUILayout.EndArea();
    //}
}
