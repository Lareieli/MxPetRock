using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class MenuManager : MonoBehaviour {

    public List<GameObject> menuItems;
    private GameObject currentItem;
    private int menuIndex;    

    private void InitializeComponent()
    {
        menuItems = new List<GameObject>();
    }

    public void MenuItemSwitcher()
    {
        //buttonGroups = GetComponentsInChildren<ToggleGroup>(true);
        // menuIndex = Button Group that Onclick event called
        currentItem = menuItems[menuIndex];
        Debug.Log(currentItem);
        //currentItem.gameObject.SetActive(true);
        for (var i = 0; i < menuItems.Count; i++)
        {
            if (i != menuIndex)
            {
                menuItems[i].SetActive(false);
            }
        }
    }
    
    //public GameObject item1;
    //public GameObject item2;

    //void Start() {
    //    item1.gameObject.SetActive(true);
    //    item2.gameObject.SetActive(false);

    //}

    //public void MenuSwitch() {
    //    item1.gameObject.SetActive(false);
    //    item2.gameObject.SetActive(false);
    //}
}
