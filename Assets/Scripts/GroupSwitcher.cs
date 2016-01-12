using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class GroupSwitcher : MonoBehaviour {

    public Component[] buttonGroups;
    private Component groupOn;
    public static int buttonIndex;
    
    public void SwitchChildren()
    {
        //int buttonIndex = GroupCaller.callingIndex;
          
        buttonGroups = GetComponentsInChildren<ToggleGroup>(true);                    
       
        for (var i = 0; i < buttonGroups.Length; i++)
        {
            if (i == buttonIndex)
            {
                buttonGroups[i].gameObject.SetActive(true);
            }
        }       

        groupOn = buttonGroups[buttonIndex];

        for (var i = 0; i < buttonGroups.Length; i++)
        {
            if (i != buttonIndex)
            {
                buttonGroups[i].gameObject.SetActive(false);
            }
        }        
    }   
}
