using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagTrigger : MonoBehaviour
{
   [SerializeField] AudioClip _audioClip;

    Animator _animator;
    AudioSource _audioSource;
    
    private void Start()
    {
        _animator = GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();

        _animator.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Player")
        {
            _animator.enabled = true;
            _audioSource.PlayOneShot(_audioClip);
        }
    }
}
