using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flap : MonoBehaviour
{
    public class MusicPlayer : MonoBehaviour
    {
        private AudioSource audioSource;

        void Start()
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.loop = false; // Pastikan loop dimatikan di AudioSource
        }

        void Update()
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play(); // Memulai lagu lagi jika sudah selesai
            }
        }
    }
}