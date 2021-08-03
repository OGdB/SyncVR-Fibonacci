using System.Collections;
using UnityEngine;

public class Fibonacci : MonoBehaviour
{
    #region Variables
    [SerializeField] private int N1 = 0;
    [SerializeField] private int N2 = 1;
    [SerializeField] private float fadeSpeed = 3f;

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
        int newNumber = N1 + N2;

        N1 = N2;
        N2 = newNumber;

        n1Text.text = N1.ToString();
        n2Text.text = N2.ToString();
    }

/// <summary>
/// Fade text in or out
/// </summary>
/// <param name="text"></param>
/// <param name="fadeIn"></param>
/// <returns></returns>
    private IEnumerator FadeText(TMPro.TextMeshPro text, bool fadeIn)
    {
        int targetAlpha = fadeIn ? 1 : 0;
        float startTime = Time.time;
        float startAlpha = text.color.a;

        while (text.color.a != targetAlpha)
        {
            float timeSinceStarted = Time.time - startTime;
            float progress = timeSinceStarted / fadeSpeed;

            float newAlpha = Mathf.Lerp(startAlpha, targetAlpha, progress);

            Color newColor = text.color;
            newColor.a = newAlpha;

            text.color = newColor;

            yield return new WaitForFixedUpdate();
        }
    }
}
