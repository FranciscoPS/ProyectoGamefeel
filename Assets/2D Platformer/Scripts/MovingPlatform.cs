using DG.Tweening;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform platform;
    public Transform destination;
    public float tweenTime;
    private Tween platformTween;
    public Ease tweenEase;

    void Start()
    {
        platformTween = platform.DOMove(destination.position, tweenTime).SetLoops(-1, LoopType.Yoyo).SetEase(tweenEase);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            platformTween.Pause();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            platformTween.Play();
    }
}
