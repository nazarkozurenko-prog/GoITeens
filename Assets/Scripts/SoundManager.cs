using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource67;
    [SerializeField] private AudioSource _soundSource68;

    private void sorrrr()
    {
        if (!_audioSource67.isPlaying)
        {
            _audioSource67.Play();
            return;
        }
        if (_audioSource67.isPlaying)
        {

        }
        _audioSource67.Stop();
        return;
    }

    private void OnEnable()
    {
        InputManager.OnSpacePressed += sorrrr;
    }

    private void OnDisable()
    {
        InputManager.OnSpacePressed -= sorrrr;
    }
}
