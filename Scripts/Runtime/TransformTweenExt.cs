using System;
using System.Collections;
using UnityEngine;

namespace EnvDev
{
    public static class TransformTweenExt
    {
        #region Local Rotation

        public static IEnumerator TweenLocalRotationBy(this Transform rectTransform, Vector3 targetRotation,
            float duration, Func<double, double> easeFunc)
        {
            var startRotation = rectTransform.localEulerAngles;
            return TweenLocalRotation(rectTransform, startRotation, startRotation + targetRotation, duration, easeFunc);
        }

        public static IEnumerator TweenLocalRotationTo(this Transform rectTransform, Vector3 targetRotation,
            float duration, Func<double, double> easeFunc)
        {
            var startRotation = rectTransform.localEulerAngles;
            return TweenLocalRotation(rectTransform, startRotation, targetRotation, duration, easeFunc);
        }

        public static IEnumerator TweenLocalRotation(this Transform rectTransform, Vector3 startRotation,
            Vector3 targetRotation, float duration, Func<double, double> easeFunc)
        {
            return EaseRoutines.TweenRoutine(duration,
                t => { rectTransform.localEulerAngles = Vector3.LerpUnclamped(startRotation, targetRotation, t); },
                easeFunc);
        }

        #endregion

        #region Local Position

        #region X

        public static IEnumerator TweenLocalX(this Transform rectTransform, float startX, float targetX,
            float duration, Func<double, double> easeFunc)
        {
            var startPosition = rectTransform.localPosition;
            startPosition.x = startX;

            var targetPosition = startPosition;
            targetPosition.x = targetX;

            return TweenLocalPosition(rectTransform, startPosition, targetPosition, duration, easeFunc);
        }

        public static IEnumerator TweenLocalXTo(this Transform rectTransform, float targetX, float duration,
            Func<double, double> easeFunc)
        {
            var startPosition = rectTransform.localPosition;

            var targetPosition = startPosition;
            targetPosition.x = targetX;

            return TweenLocalPosition(rectTransform, startPosition, targetPosition, duration, easeFunc);
        }

        #endregion

        #region Y

        public static IEnumerator TweenLocalY(this Transform rectTransform, float startY, float targetY,
            float duration, Func<double, double> easeFunc)
        {
            var startPosition = rectTransform.localPosition;
            startPosition.y = startY;

            var targetPosition = startPosition;
            targetPosition.y = targetY;

            return TweenLocalPosition(rectTransform, startPosition, targetPosition, duration, easeFunc);
        }

        public static IEnumerator TweenLocalYTo(this Transform rectTransform, float targetY, float duration,
            Func<double, double> easeFunc)
        {
            var startPosition = rectTransform.localPosition;

            var targetPosition = startPosition;
            targetPosition.y = targetY;

            return TweenLocalPosition(rectTransform, startPosition, targetPosition, duration, easeFunc);
        }

        #endregion

        #region Z
        
        public static IEnumerator TweenLocalZ(this Transform rectTransform, float startZ, float targetZ,
            float duration, Func<double, double> easeFunc)
        {
            var startPosition = rectTransform.localPosition;
            startPosition.z = startZ;

            var targetPosition = startPosition;
            targetPosition.z = targetZ;

            return TweenLocalPosition(rectTransform, startPosition, targetPosition, duration, easeFunc);
        }

        public static IEnumerator TweenLocalZTo(this Transform rectTransform, float targetZ, float duration,
            Func<double, double> easeFunc)
        {
            var startPosition = rectTransform.localPosition;

            var targetPosition = startPosition;
            targetPosition.z = targetZ;

            return TweenLocalPosition(rectTransform, startPosition, targetPosition, duration, easeFunc);
        }
        
        #endregion

        public static IEnumerator TweenLocalPositionBy(this Transform rectTransform, Vector3 deltaPosition,
            float duration, Func<double, double> easeFunc)
        {
            var startPosition = rectTransform.localPosition;
            var targetPosition = startPosition + deltaPosition;
            return TweenLocalPosition(rectTransform, startPosition, targetPosition, duration, easeFunc);
        }
        
        public static IEnumerator TweenLocalPositionTo(this Transform rectTransform, Vector3 targetPosition,
            float duration, Func<double, double> easeFunc)
        {
            var startPosition = rectTransform.localPosition;
            return TweenLocalPosition(rectTransform, startPosition, targetPosition, duration, easeFunc);
        }

        public static IEnumerator TweenLocalPosition(this Transform rectTransform, Vector3 startPosition,
            Vector3 targetPosition, float duration, Func<double, double> easeFunc)
        {
            return EaseRoutines.TweenRoutine(duration,
                t => { rectTransform.localPosition = Vector3.LerpUnclamped(startPosition, targetPosition, t); },
                easeFunc);
        }

        #endregion

        #region Position

        public static IEnumerator TweenPositionTo(this Transform rectTransform, Vector3 targetPosition,
            float duration, Func<double, double> easeFunc)
        {
            var startPosition = rectTransform.position;
            return TweenPosition(rectTransform, startPosition, targetPosition, duration, easeFunc);
        }

        public static IEnumerator TweenPosition(this Transform rectTransform, Vector3 startPosition, Vector3 targetPosition,
            float duration, Func<double, double> easeFunc)
        {
            return EaseRoutines.TweenRoutine(duration,
                t => { rectTransform.position = Vector3.LerpUnclamped(startPosition, targetPosition, t); }, easeFunc);
        }

        #endregion

        #region Local Scale

        public static IEnumerator TweenLocalScaleTo(this Transform rectTransform, float targetValue, float duration,
            Func<double, double> easeFunc)
        {
            var startValue = rectTransform.localScale;
            var targetScale = new Vector3(targetValue, targetValue, targetValue);
            return TweenLocalScale(rectTransform, startValue, targetScale, duration, easeFunc);
        }

        public static IEnumerator TweenLocalScale(this Transform rectTransform, Vector3 targetScale, float duration,
            Func<double, double> easeFunc)
        {
            var startValue = rectTransform.localScale;
            return TweenLocalScale(rectTransform, startValue, targetScale, duration, easeFunc);
        }

        public static IEnumerator TweenLocalScale(this Transform rectTransform, Vector3 startScale, Vector3 targetScale,
            float duration, Func<double, double> easeFunc)
        {
            return EaseRoutines.TweenRoutine(duration,
                t => { rectTransform.localScale = Vector3.LerpUnclamped(startScale, targetScale, t); }, easeFunc);
        }

        #endregion
    }

}