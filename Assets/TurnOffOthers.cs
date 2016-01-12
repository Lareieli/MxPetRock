using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TurnOffOthers : MonoBehaviour {


    public Component[] buttonGroups;
    // Use this for initialization
    void Start () {
	buttonGroups = GetComponentsInChildren<ToggleGroup>(true);
        Debug.Log("I am" + buttonGroups);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
 
}
