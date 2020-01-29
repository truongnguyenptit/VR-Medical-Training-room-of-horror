using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactObject : MonoBehaviour
{
    private GameObject player;
    private bool hasInteracted = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        hasInteracted = false;
    }
    public void interactable() {
        if (hasInteracted == false) {
            player.GetComponent<playerScore>().AddScore();
            hasInteracted = true;
        }
       
    
    }
}
