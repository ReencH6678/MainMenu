using UnityEngine;
using UnityEngine.Audio;

public class Mixer : MonoBehaviour
{
    private const float MaxVolume = 0;
    private const float MinVolume = -80;

    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private Groups _groupName;

    private enum Groups
    {
        Master,
        Sounds,
        Background
    }

    private float _volumeRation = 20;

    public void ChangeVolume(float velue)
    {
        Debug.Log(_groupName.ToString());
        _audioMixer.SetFloat(_groupName.ToString(), Mathf.Log10(velue) * _volumeRation);
    }
}
