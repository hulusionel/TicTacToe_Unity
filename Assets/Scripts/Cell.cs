using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    public Text mLabel;
    public Button mButton;
    public Main mMain;
	
    public void Fill()
    {
        mButton.interactable = false;
        mLabel.text = mMain.GetTurnCharacter();
        mMain.Switch();
    }
}
