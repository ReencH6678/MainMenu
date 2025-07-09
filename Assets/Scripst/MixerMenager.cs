using UnityEngine;
using UnityEngine.Audio;

public class MixerMenager : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixer;

    private const string Master = "MasterVolume";
    private const string Sound = "SoundsVolume";
    private const string BachgroundMusik = "BackgroundMusikVolume";

    private const float MaxVolume = 0;
    private const float MinVolume = -80;

    private float _volumeRation = 20;
    
    private float _masterVolumeCount;
    private bool _isMusikOn = true;

    public void ChangeMasterVolume(float velue)
    {
        _masterVolumeCount = Mathf.Log10(velue) * _volumeRation;
        _audioMixer.audioMixer.SetFloat(Master, _masterVolumeCount);
    }

    public void ChangeSoundsVolume(float velue)
    {
        _audioMixer.audioMixer.SetFloat(Sound, Mathf.Log10(velue) * _volumeRation);
    }

    public void ChangeBackgroundMusikVolume(float velue)
    {
        _audioMixer.audioMixer.SetFloat(BachgroundMusik, Mathf.Log10(velue) * _volumeRation);
    }

    public void ToggleSounds()
    {
        _isMusikOn = !_isMusikOn;

        if (_isMusikOn == false)
            _audioMixer.audioMixer.SetFloat(Master, MinVolume);
        else
            _audioMixer.audioMixer.SetFloat(Master, _masterVolumeCount);
    }
}
