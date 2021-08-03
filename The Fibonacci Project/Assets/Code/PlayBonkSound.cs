using UnityEngine;

public class PlayBonkSound : MonoBehaviour
{
    private AudioSource source = null;
    [SerializeField] private AudioClip bonk = null;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }
    public void BonkSound()
    {
        source.PlayOneShot(bonk);
    }
}
