using System;
using System.Collections;
using UnityEngine;

namespace EnvDev
{
    public static class TransformTweenExt
    {
        #region Local Rotation

        public static IEnumerator TweenLocalRotationBy(this Transform rectTransform, float duration,
            Vector3 targetRotation, Func<double, double> easeFunc)
        {
            var startRotation = rectTransform.localEulerAngles;
            return TweenLocalRotation(rectTransform, duration, startRotation, startRotation + targetRotation, easeFunc);
        }

        public static IEnumerator TweenLocalRotationTo(this Transform rectTransform, float duration,
            Vector3 targetRotation, Func<double, double> easeFunc)
        {
            var startRotation = rectTransform.localEulerAngles;
            return TweenLocalRotation(rectTransform, duration, startRotation, targetRotation, easeFunc);
        }

        public static IEnumerator TweenLocalRotation(this Transform rectTransform, float duration,
            Vector3 startRotation, Vector3 targetRotation, Func<double, double> easeFunc)
        {
            return EaseRoutines.TweenRoutine(duration,
                t => { rectTransform.localEulerAngles = Vector3.LerpUnclamped(startRotation, targetRotation, t); },
                easeFunc);
        }

        #endregion

        #region Local Position

        #region X

        public static IEnumerator TweenLocalX(this Transform rectTransform, float duration, float startX,
            float targetX,
            Func<double, double> easeFunc)
        {
            var startPosition = rectTransform.localPosition;
            startPosition.x = startX;

            var targetPosition = startPosition;
            targetPosition.x = targetX;

            return TweenLocalPosition(rectTransform, duration, startPosition, targetPosition, easeFunc);
        }

        public static IEnumerator TweenLocalXTo(this Transform rectTransform, float duration, float targetX,
            Func<double, double> easeFunc)
        {
            var startPosition = rectTransform.localPosition;

            var targetPosition = startPosition;
            targetPosition.x = targetX;

            return TweenLocalPosition(rectTransform, duration, startPosition, targetPosition, easeFunc);
        }

        #endregion

        #region Y

        public static IEnumerator TweenLocalY(this Transform rectTransform, float duration, float startY,
            float targetY,
            Func<double, double> easeFunc)
        {
            var startPosition = rectTransform.localPosition;
            startPosition.y = startY;

            var targetPosition = startPosition;
            targetPosition.y = targetY;

            return TweenLocalPosition(rectTransform, duration, startPosition, targetPosition, easeFunc);
        }

        public static IEnumerator TweenLocalYTo(this Transform rectTransform, float duration, float targetY,
            Func<double, double> easeFunc)
        {
            var startPosition = rectTransform.localPosition;

            var targetPosition = startPosition;
            targetPosition.y = targetY;

            return TweenLocalPosition(rectTransform, duration, startPosition, targetPosition, easeFunc);
        }

        #endregion

        #region Z
        
        public static IEnumerator TweenLocalZ(this Transform rectTransform, float duration, float startZ,
            float targetZ,
            Func<double, double> easeFunc)
        {
            var startPosition = rectTransform.localPosition;
            startPosition.z = startZ;

            var targetPosition = startPosition;
            targetPosition.z = targetZ;

            return TweenLocalPosition(rectTransform, duration, startPosition, targetPosition, easeFunc);
        }

        public static IEnumerator TweenLocalZTo(this Transform rectTransform, float duration, float targetZ,
            Func<double, double> easeFunc)
        {
            var startPosition = rectTransform.localPosition;

            var targetPosition = startPosition;
            targetPosition.z = targetZ;

            return TweenLocalPosition(rectTransform, duration, startPosition, targetPosition, easeFunc);
        }
        
        #endregion

        public static IEnumerator TweenLocalPositionBy(this Transform rectTransform, float duration,
            Vector3 deltaPosition, Func<double, double> easeFunc)
        {
            var startPosition = rectTransform.localPosition;
            var targetPosition = startPosition + deltaPosition;
            return TweenLocalPosition(rectTransform, duration, startPosition, targetPosition, easeFunc);
        }
        
        public static IEnumerator TweenLocalPositionTo(this Transform rectTransform, float duration,
            Vector3 targetPosition, Func<double, double> easeFunc)
        {
            var startPosition = rectTransform.localPosition;
            return TweenLocalPosition(rectTransform, duration, startPosition, targetPosition, easeFunc);
        }

        public static IEnumerator TweenLocalPosition(this Transform rectTransform, float duration,
            Vector3 startPosition, Vector3 targetPosition, Func<double, double> easeFunc)
        {
            return EaseRoutines.TweenRoutine(duration,
                t => { rectTransform.localPosition = Vector3.LerpUnclamped(startPosition, targetPosition, t); },
                easeFunc);
        }

        #endregion

        #region Position

        public static IEnumerator TweenPositionTo(this Transform rectTransform, float duration,
            Vector3 targetPosition, Func<double, double> easeFunc)
        {
            var startPosition = rectTransform.position;
            return TweenPosition(rectTransform, duration, startPosition, targetPosition, easeFunc);
        }

        public static IEnumerator TweenPosition(this Transform rectTransform, float duration, Vector3 startPosition,
            Vector3 targetPosition, Func<double, double> easeFunc)
        {
            return EaseRoutines.TweenRoutine(duration,
                t => { rectTransform.position = Vector3.LerpUnclamped(startPosition, targetPosition, t); }, easeFunc);
        }

        #endregion

        #region Local Scale

        public static IEnumerator TweenLocalScaleTo(this Transform rectTransform, float duration, float targetValue,
            Func<double, double> easeFunc)
        {
            var startValue = rectTransform.localScale;
            var targetScale = new Vector3(targetValue, targetValue, targetValue);
            return TweenLocalScale(rectTransform, duration, startValue, targetScale, easeFunc);
        }

        public static IEnumerator TweenLocalScale(this Transform rectTransform, float duration, Vector3 targetScale,
            Func<double, double> easeFunc)
        {
            var startValue = rectTransform.localScale;
            return TweenLocalScale(rectTransform, duration, startValue, targetScale, easeFunc);
        }

        public static IEnumerator TweenLocalScale(this Transform rectTransform, float duration, Vector3 startScale,
            Vector3 targetScale, Func<double, double> easeFunc)
        {
            return EaseRoutines.TweenRoutine(duration,
                t => { rectTransform.localScale = Vector3.LerpUnclamped(startScale, targetScale, t); }, easeFunc);
        }

        #endregion
    }

}