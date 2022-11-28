using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Narrator : MonoBehaviour
{
    [SerializeField]
    AudioClip introSpeech;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayIntroSpeech());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PlayIntroSpeech()
    {
        yield return new WaitForSeconds(2f);
        GetComponent<AudioSource>().PlayOneShot(introSpeech);
    }
}
