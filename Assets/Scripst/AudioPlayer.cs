using UnityEngine;
using UnityEngine.UI;

public class AudioPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSourse;
    private Button _playButton;

    private void Awake
        ()
    {
        _playButton.onClick.AddListener(Play);
    }
    private void Play()
    {
        _audioSourse.Play();
    }
}
