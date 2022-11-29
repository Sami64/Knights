using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Narrator : MonoBehaviour
{
    [SerializeField]
    AudioClip introSpeech;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(PlayIntroSpeech());
       
    }

    // Update is called once per frame
    void Update()
    {
        
            
        

        
    }

    IEnumerator PlayIntroSpeech()
    {
        yield return new WaitForSeconds(0.5f);
        GetComponent<AudioSource>().PlayOneShot(introSpeech);
        animator.SetTrigger("Talk");
        Invoke("SitDown", introSpeech.length);
        
    }

    void SitDown()
    {
        animator.SetTrigger("Sit");
    }
}
