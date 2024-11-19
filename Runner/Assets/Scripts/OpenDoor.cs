using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] AudioClip _audioClip;


    Animator _animator;
    AudioSource _audioSource;

    private void Start()
    {
        _animator = GetComponentInChildren<Animator>();
        _audioSource = GetComponent<AudioSource>();

        _animator.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _animator.enabled = true;
            _audioSource.PlayOneShot(_audioClip);
        }
    }
}
