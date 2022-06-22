using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pigSound : MonoBehaviour
{
    public AudioClip[] oink;
    public AudioSource s;
    private void FixedUpdate()
    {
        if (!s.isPlaying)
        {
            StartCoroutine(sa());
        }
    }
    IEnumerator sa()
    {
        yield return new WaitForSeconds(Random.Range(2,10));
        if (!s.isPlaying)
        {
            s.clip = oink[Random.Range(0, oink.Length)];
            s.Play();
        }
    }
}
