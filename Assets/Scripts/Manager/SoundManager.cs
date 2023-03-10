using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public enum Sound 
    {
        Miss,
        Failed,
        Success,
        Selected
    }

    /*
        Funções que delega uma constraint de um som
        ou seja, alguma restrição que você queira impor,
        por padrão a constraint definida é a default
        que apenas retorna true
    */
    public delegate bool DelegateConstraintFunction(); 

    [System.Serializable]
    public class SoundAudioClip
    {
        public Sound _Sound;
        public AudioClip _AudioClip;
        public DelegateConstraintFunction _ConstraintFunction = DefaultConstraint;
    }

    public SoundAudioClip[] SoundAudioClipArray;

    [HideInInspector]
    public AudioSource _AudioSource;

    private void Awake()
    {
        if(Instance != null) {
            Destroy(gameObject);
            return;
        }
        
        DontDestroyOnLoad(this);
        Instance = this;
        Instance._AudioSource = Instance.GetComponent<AudioSource>();
    }

    public static void PlaySound(Sound _Sound)
    {
        SoundAudioClip _SoundAudioClip = GetSoundAudioClip(_Sound);
        if(_SoundAudioClip != null && _SoundAudioClip._ConstraintFunction()) {
            Instance._AudioSource.PlayOneShot(_SoundAudioClip._AudioClip);
        }
    }

    public static void SetConstraintSound(Sound _Sound, DelegateConstraintFunction _ConstraintFunction)
    {
        SoundAudioClip _SoundAudioClip = GetSoundAudioClip(_Sound);
        _SoundAudioClip._ConstraintFunction = _ConstraintFunction;
    }

    private static SoundAudioClip GetSoundAudioClip(Sound _Sound)
    {
        foreach (SoundAudioClip _SoundAudioClip in Instance.SoundAudioClipArray)
        {
            if(_SoundAudioClip._Sound == _Sound) {
                return _SoundAudioClip;
            }
        }
        
        Debug.LogError("Sound " + _Sound + " not found");
        return null;
    }

    public static bool DefaultConstraint()
    {
        Debug.Log("DefaultConstraint()");
        return true;
    }
}
