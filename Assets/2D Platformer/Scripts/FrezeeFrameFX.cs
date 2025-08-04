using System.Collections;
using UnityEngine;

public class FrezeeFrameFX : MonoBehaviour
{
    public float freezeDuration;
    public float freezeTimeValue;
    private Coroutine freezeCoroutine;

    public void FreezeFrame()
    {
        if (freezeCoroutine != null)
        {
            StopCoroutine(freezeCoroutine);
        }

        freezeCoroutine = StartCoroutine(FreezeFrameRoutine());
    }

    IEnumerator FreezeFrameRoutine()
    {
        Time.timeScale = freezeTimeValue;
        yield return new WaitForSecondsRealtime(freezeDuration);
        Time.timeScale = 1;
    }
}
