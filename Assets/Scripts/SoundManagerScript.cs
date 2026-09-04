using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static SoundManagerScript instance;
    public float masterVolume = 0.10f;

    public AudioClip jumpSound;
    public AudioClip deathSound;
    public AudioClip goldSound;
    public AudioClip scoreSound;
    public AudioClip backgroundMusic;
    private AudioSource soundSource;
    private AudioSource musicSource;

    void Awake()
    {
        instance = this;

        AudioListener.volume = 0.1f;

        soundSource = gameObject.AddComponent<AudioSource>();
        musicSource = gameObject.AddComponent<AudioSource>();
        musicSource.clip = backgroundMusic;
        musicSource.loop = true;
        musicSource.Play();
    }
    public void PlayJumpSound()
    {
        soundSource.PlayOneShot(jumpSound);
    }

    public void PlayDeathSound()
    {
        soundSource.PlayOneShot(deathSound);
    }

    public void PlayGoldSound()
    {
        soundSource.PlayOneShot(goldSound);
    }

    public void PlayScoreSound()
    {
        soundSource.PlayOneShot(scoreSound);
    }
}
