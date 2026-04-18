using UnityEngine;
using System.Collections;

public class TextFader : MonoBehaviour
{
    private CanvasGroup canvasGroup;

    void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    // Call this method to start the fade
    public void StartFade()
    {
        StartCoroutine(FadeInAndOut());
    }

    IEnumerator FadeInAndOut()
    {
        // Fade In
        while (canvasGroup.alpha < 1)
        {
            canvasGroup.alpha += Time.deltaTime / 2f; // Fades over 2 seconds
            yield return null;
        }

        yield return new WaitForSeconds(1f); // Wait while text is visible

        // Fade Out
        while (canvasGroup.alpha > 0)
        {
            canvasGroup.alpha -= Time.deltaTime / 2f;
            yield return null;
        }
    }
}
