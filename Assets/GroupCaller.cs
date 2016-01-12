using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class GroupCaller : MonoBehaviour {

    public Component[] callingButtons;    
    public static int callingIndex;   
         
    public void OnEnable()
    {
        callingButtons = GetComponentsInChildren<Button>(true);        
        
        
        
    }

    public void AnnounceIndex() {

        //callingIndex = index of item this script is attached to
        // from array callingButtons created when Panel Manager is enabled

        Debug.Log(callingIndex.ToString());
    }
   

    






}
