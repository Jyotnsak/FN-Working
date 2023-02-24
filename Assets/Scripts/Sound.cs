using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour

{
    public GameObject slicer;
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            source.Play();
        }
    }
}
