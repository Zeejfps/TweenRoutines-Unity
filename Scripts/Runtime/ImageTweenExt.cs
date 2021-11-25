using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace EnvDev
{
    public static class ImageTweenExt
    {
        #region Alpha

        public static IEnumerator TweenAlphaTo(this Image image, float duration, float targetAlpha,
            Func<double, double> easeFunc)
        {
            var startAlpha = image.color.a;
            return TweenAlpha(image, duration, startAlpha, targetAlpha, easeFunc);
        }
        
        public static IEnumerator TweenAlphaFrom(this Image image, float duration, float startAlpha,
            Func<double, double> easeFunc)
        {
            var targetAlpha = image.color.a;
            return TweenAlpha(image, duration, startAlpha, targetAlpha, easeFunc);
        }
        
        public static IEnumerator TweenAlpha(this Image image, float duration, float startAlpha, float targetAlpha,
            Func<double, double> easeFunc)
        {
            var startColor = image.color;
            startColor.a = startAlpha;
            
            var targetColor = image.color;
            targetColor.a = targetAlpha;

            return TweenColor(image, duration, startColor, targetColor, easeFunc);
        }

        #endregion
        
        #region Color

        public static IEnumerator TweenColorTo(this Image image, float duration, Color targetColor,
            Func<double, double> easeFunc)
        {
            var startColor = image.color;
            return TweenColor(image, duration, startColor, targetColor, easeFunc);
        }
        
        public static IEnumerator TweenColorFrom(this Image image, float duration, Color startColor,
            Func<double, double> easeFunc)
        {
            var targetColor = image.color;
            return TweenColor(image, duration, startColor, targetColor, easeFunc);
        }
        
        public static IEnumerator TweenColor(this Image image, float duration, Color startColor, Color targetColor,
            Func<double, double> easeFunc)
        {
            return EaseRoutines.TweenRoutine(duration, t =>
            {
                image.color = Color.LerpUnclamped(startColor, targetColor, t);
            }, easeFunc);
        }

        #endregion
    }
}