using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSourse;

    public void Play()
    {
        _audioSourse.Play();
    }
}
