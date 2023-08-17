using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalVolumeView : MonoBehaviour
{
    [SerializeField] GlobalVolume _volume;
    [SerializeField] Image _image;

    [SerializeField] private Sprite _on;
    [SerializeField] private Sprite _off;
    [SerializeField] private AudioSource _audioSource;

    private void OnEnable()
    {
        _volume.Muted += OnVolumeMuted;
    }

    private void OnDisable()
    {
        _volume.Muted -= OnVolumeMuted;
    }

    private void OnVolumeMuted(bool mute)
    {
        if (mute)
        {
            _image.sprite = _off;
            _audioSource.mute = true;
        }
        else
        {
            _image.sprite = _on;
            _audioSource.mute = false;
        }
    }
}
