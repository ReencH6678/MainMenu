using UnityEngine;
using UnityEngine.Audio;

public class ToggleSound : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;

    [SerializeField] private Groups _group;

    private enum Groups
    {
        Master,
        Sounds,
        Background
    }

    private const float MinVolume = -80;

    private float _currentVolumeCount;
    private bool _isOn = true;

    public void ToggleSounds()
    {
        _isOn = !_isOn;

        if (_isOn == false)
            _audioMixer.SetFloat(_group.ToString(), MinVolume);
        else
            _audioMixer.SetFloat(_group.ToString(), _currentVolumeCount);
    }
}
