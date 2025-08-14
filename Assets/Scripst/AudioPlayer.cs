using UnityEngine;
using UnityEngine.UI;

public class AudioPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSourse;
    private Button _playButton;

    private void Awake()
    {
        _playButton = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _playButton.onClick.AddListener(Play);
    }

    private void OnDisable()
    {
        _playButton.onClick.RemoveListener(Play);
    }

    private void Play()
    {
        _audioSourse.Play();
    }
}
