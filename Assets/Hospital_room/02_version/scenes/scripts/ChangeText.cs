using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    public TextMesh myText;
    private bool isChosen;

    private void Start()
    {
        myText = transform.GetComponent<TextMesh>();
        isChosen = false;
    }


    public void chooseCorrect() {

        if (isChosen == false) {
            myText.text = "You Are Correct!";
            isChosen = true;
        }
    
    
    }

    public void chooseWrong()
    {

        if (isChosen == false)
        {
            myText.text = "You Are Wrong!";
            isChosen = true;
        }


    }



}
