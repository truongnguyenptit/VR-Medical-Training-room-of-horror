using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playMyAnimation : MonoBehaviour
{
     [SerializeField] private Animator myAnmiationController;
    private bool isTalk = false;
    public AudioClip audio;
    private AudioSource audioSource;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audio;

    }
    public void BeginTalk() {
        if (isTalk == false) {
            myAnmiationController.SetBool("isTalking", true);
            StartCoroutine(WaitForSound());

        }
          
       
    }
    public IEnumerator WaitForSound() {
        audioSource.Play();
        yield return new WaitUntil(() => audioSource.isPlaying == false);
        myAnmiationController.SetBool("isTalking", false);

    }


}
