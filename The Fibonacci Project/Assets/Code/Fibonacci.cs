using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Fibonacci : MonoBehaviour
{
    [SerializeField] private int N1 = 0;
    [SerializeField] private int N2 = 1;

    [Header("Assignables")]
    [Space(5)]
    [SerializeField] private TMPro.TextMeshPro n1Text = null;
    [SerializeField] private TMPro.TextMeshPro n2Text = null;
    [SerializeField] private TMPro.TextMeshPro n3Text = null;

    private AudioSource audioSource = null;
    [SerializeField] private AudioClip clip = null;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        n1Text.text = N1.ToString();
        n2Text.text = N2.ToString();
    }

    public void GetNextFibonacciSequence()
    {
        int newNumber = N1 + N2;

        N1 = N2;
        N2 = newNumber;

        n1Text.text = N1.ToString();
        n2Text.text = N2.ToString();

        n3Text.text = newNumber.ToString();

        audioSource.Play();
    }
}
