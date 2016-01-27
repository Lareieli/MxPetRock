using UnityEngine;
using UnityEngine.UI;

public class TextSwitcher : MonoBehaviour {
    
    public Text text;

    public void TextUpdater() {

        text.text = (text.ToString());
    }
}
