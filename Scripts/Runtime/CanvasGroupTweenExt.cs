using System;
using System.Collections;
using UnityEngine;

namespace EnvDev
{
    public static class CanvasGroupTweenExt
    {
        #region Alpha
        
        public static IEnumerator TweenAlphaBy(this CanvasGroup canvasGroup, float duration, float alphaDelta,
            Func<double, double> easeFunc)
        {
            var startAlpha = canvasGroup.alpha;
            var targetAlpha = startAlpha + alphaDelta;
            return TweenAlpha(canvasGroup, duration, startAlpha, targetAlpha, easeFunc);
        }
        
        public static IEnumerator TweenAlphaTo(this CanvasGroup canvasGroup, float duration, float targetAlpha,
            Func<double, double> easeFunc)
        {
            var startAlpha = canvasGroup.alpha;
            return TweenAlpha(canvasGroup, duration, startAlpha, targetAlpha, easeFunc);
        }
        
        public static IEnumerator TweenAlphaFrom(this CanvasGroup canvasGroup, float duration, float startAlpha,
            Func<double, double> easeFunc)
        {
            var targetAlpha = canvasGroup.alpha;
            return TweenAlpha(canvasGroup, duration, startAlpha, targetAlpha, easeFunc);
        }
        
        public static IEnumerator TweenAlpha(this CanvasGroup canvasGroup, float duration, float startAlpha,
            float targetAlpha, Func<double, double> easeFunc)
        {
            return EaseRoutines.TweenRoutine(duration, t =>
            {
                canvasGroup.alpha = Mathf.LerpUnclamped(startAlpha, targetAlpha, t);
            }, easeFunc);
        }
        
        #endregion
    }
}