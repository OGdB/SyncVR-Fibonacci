using System.Numerics;
using UnityEngine;

public class Fibonacci : MonoBehaviour
{
    #region Variables
    private BigInteger N1 = 0;
    private BigInteger N2 = 1;

    [Header("Assignables")]
    [Space(5)]
    [SerializeField] private TMPro.TextMeshPro n1Text = null;
    [SerializeField] private TMPro.TextMeshPro n2Text = null;
    [SerializeField] private Animator animator = null;
    #endregion
    
    private void Start() => ChangeNumbers();

    private void ChangeNumbers()
    {
        n1Text.text = N1.ToString();
        n2Text.text = N2.ToString();
    }

    public void StartAnimation()
    {
        if (!animator.GetCurrentAnimatorStateInfo(0).IsName("Bonk"))
        {
            animator.Play("Bonk");
        }
    }

    public void GetNextFibonacciSequence()
    {
        BigInteger newNumber = N1 + N2;

        N1 = N2;
        N2 = newNumber;

        ChangeNumbers();

        // Instantiate New TMPro Text (Prefab?) moving to a location under the N2 Transform.
            // New TMPro.TextMeshPro
            // Set values
            // Start Animation

        // Camera accordingly moves down a bit.
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetNextFibonacciSequence();
        }
    }

    // N1 Knocks N2 away and becomes the sum of the numbers.
    // N2 gets knocked away and goes to N1
    // In the end the numbers and their values switch around in the background.
    // =Reset

}
