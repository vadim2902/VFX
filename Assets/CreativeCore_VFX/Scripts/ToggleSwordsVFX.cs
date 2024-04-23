using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSwordsVFX : MonoBehaviour
{
    private ParticleSystem particle;

    private bool _isPlaying = true;

    // Start is called before the first frame update
    void Start()
    {
        particle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_isPlaying)
            {
                particle.Stop();
                _isPlaying = false;
            }
            else
            {
                particle.Play();
                _isPlaying = true;
            }
        }
    }
}
