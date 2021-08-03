using System.Collections;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    private RectTransform buttonTransform = null;
    [SerializeField] private float targetSize = 0.95f;
    private void Start()
    {
        buttonTransform = GetComponent<RectTransform>();
    }
    public void ButtonClicked()
    {
        StopAllCoroutines();
        StartCoroutine(OnButtonClick());
    }
    private IEnumerator OnButtonClick()
    {
        float startTime = Time.time;
        float size = 1f;

        while (buttonTransform.localScale.x > targetSize)
        {
            float timeSinceStarted = Time.time - startTime;
            float progress = timeSinceStarted / 0.1f;

            size = Mathf.Lerp(1f, targetSize, progress);

            buttonTransform.localScale = Vector3.one * size;

            yield return new WaitForFixedUpdate();
        }

        while (buttonTransform.localScale.x < 1f)
        {
            float timeSinceStarted = Time.time - startTime;
            float progress = timeSinceStarted / 0.1f;

            size = Mathf.Lerp(targetSize, 1f, progress);

            buttonTransform.localScale = Vector3.one * size;

            yield return new WaitForFixedUpdate();
        }
    }
}
