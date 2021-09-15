using System;
using System.Collections;
using JetBrains.Annotations;
using UnityEngine;

public class Easing : MonoBehaviour
{
    public enum EaseStyle
    {
        EaseLinear,
        EaseInSine,
        EaseOutSine,
        EaseInOutSine,
        EaseInCircular,
        EaseOutCircular,
        EaseInOutCircular,
        EaseInExpo,
        EaseOutExpo,
        EaseInOutExpo,
        EaseInQuad,
        EaseOutQuad,
        EaseInOutQuad,
        EaseInCub,
        EaseOutCub,
        EaseInOutCub,
        EaseInQuart,
        EaseOutQuart,
        EaseInOutQuart,
        EaseInQuint,
        EaseOutQuint,
        EaseInOutQuint
    }
    [SerializeField] private EaseStyle type;
    public delegate float EaseFunction(float a, float b, float t);
    private EaseFunction easeFunction;
    
    [SerializeField] private float startValue;
    [SerializeField] private float endValue;

    public float StartValue
    {
        set => startValue = value;
    }

    public float EndValue
    {
        set => endValue = value;
    }
    
    void Start()
    {
        //SetEase(type);
    }
    
    public void SetEase(EaseStyle easeStyle)
    {
        switch (easeStyle)
        {
            case EaseStyle.EaseLinear:
                easeFunction = EaseLinear;
                break;
            case EaseStyle.EaseInSine:
                easeFunction = EaseInSine;
                break;
            case EaseStyle.EaseOutSine:
                easeFunction = EaseOutSine;
                break;
            case EaseStyle.EaseInOutSine:
                easeFunction = EaseInOutSine;
                break;
            case EaseStyle.EaseInCircular:
                easeFunction = EaseInCircular;
                break;
            case EaseStyle.EaseOutCircular:
                easeFunction = EaseOutCircular;
                break;
            case EaseStyle.EaseInOutCircular:
                easeFunction = EaseInOutCircular;
                break;
            case EaseStyle.EaseInExpo:
                easeFunction = EaseInExpo;
                break;
            case EaseStyle.EaseOutExpo:
                easeFunction = EaseOutExpo;
                break;
            case EaseStyle.EaseInOutExpo:
                easeFunction = EaseInOutExpo;
                break;
            case EaseStyle.EaseInQuad:
                easeFunction = EaseInQuad;
                break;
            case EaseStyle.EaseOutQuad:
                easeFunction = EaseOutQuad;
                break;
            case EaseStyle.EaseInOutQuad:
                easeFunction = EaseInOutQuad;
                break;
            case EaseStyle.EaseInCub:
                easeFunction = EaseInCub;
                break;
            case EaseStyle.EaseOutCub:
                easeFunction = EaseOutCub;
                break;
            case EaseStyle.EaseInOutCub:
                easeFunction = EaseInOutCub;
                break;
            case EaseStyle.EaseInQuart:
                easeFunction = EaseInQuart;
                break;
            case EaseStyle.EaseOutQuart:
                easeFunction = EaseOutQuart;
                break;
            case EaseStyle.EaseInOutQuart:
                easeFunction = EaseInOutQuart;
                break;
            case EaseStyle.EaseInQuint:
                easeFunction = EaseInQuint;
                break;
            case EaseStyle.EaseOutQuint:
                easeFunction = EaseOutQuint;
                break;
            case EaseStyle.EaseInOutQuint:
                easeFunction = EaseInOutQuint;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        type = easeStyle;
    }

    //using this stuff??
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            StartCoroutine(EaseSelected(easeFunction, startValue, endValue));
        }
    }

    private IEnumerator EaseSelected(EaseFunction ease, float startPos, float endPos)
    {
        float t = 0;
        while (t < 1.0f)
        {
            transform.position = new Vector3(transform.position.x, Ease(ease, startPos, endPos, t, 1), transform.position.z);
            t += Time.unscaledDeltaTime;
            yield return null;
        }
        transform.position = new Vector3(transform.position.x, endPos, transform.position.z);
    }
    
    //converters
    private static float Ease(EaseFunction ease, float a, float b, float t, float d)
    {
        return ease(a, b, t / d);
    }
    
    private Vector2 Ease(EaseFunction ease, Vector2 a, Vector2 b, float t, float d)
    {
        return new Vector2(ease(a.x, b.x, t / d), ease(a.y, b.y, t / d));
    }
    
    private Vector3 Ease(EaseFunction ease,Vector3 a, Vector3 b, float t, float d)
    {
        return new Vector3(ease(a.x, b.x, t / d), ease(a.y, b.y, t / d), ease(a.z, b.z, t / d));
    }

    //the easings
    float EaseLinear(float a, float b, float t)
    {
        return a * (1 - t) + b * t;
    }
    
    float EaseInSine(float a, float b, float t)
    {
        t = 1 - Mathf.Cos(t * Mathf.PI / 2);
        return EaseLinear(a, b, t);
    }
    
    float EaseOutSine(float a, float b, float t)
    {
        t = Mathf.Sin(t * Mathf.PI / 2);
        return EaseLinear(a, b, t);
    }

    float EaseInOutSine(float a, float b, float t)
    {
        t = (1 + Mathf.Sin(((t - 0.5f) * Mathf.PI))) / 2;
        return EaseLinear(a, b, t);
    }

    float EaseInCircular(float a, float b, float t)
    {
        t = 1 - Mathf.Sqrt(1 - Mathf.Pow(t, 2));
        return EaseLinear(a, b, t);
    }
    
    float EaseOutCircular(float a, float b, float t)
    {
        t = Mathf.Sqrt(1 - Mathf.Pow((t - 1), 2));
        return EaseLinear(a, b, t);
    }
    
    float EaseInOutCircular(float a, float b, float t)
    {
        t = t < 0.5f ? 0.5f - Mathf.Sqrt(0.25f - t * t) : Mathf.Sqrt(0.25f - Mathf.Pow(t - 1, 2)) + 0.5f;
        return EaseLinear(a, b, t);
    }
    
    float EaseInExpo(float a, float b, float t)
    {
        t = 1 - Mathf.Sqrt(1 - t);
        return EaseLinear(a, b, t);
    }
    
    float EaseOutExpo(float a, float b, float t)
    {
        t = Mathf.Sqrt(t);
        return EaseLinear(a, b, t);
    }
    
    float EaseInOutExpo(float a, float b, float t)
    {
        t = t <= 0.5f ? 0.5f - Mathf.Sqrt(1 - 2 * t) / 2 : Mathf.Sqrt(2 * t - 1) / 2 + 0.5f;
        return EaseLinear(a, b, t);
    }
    
    float EaseInQuad(float a, float b, float t)
    {
        t = t * t;
        return EaseLinear(a, b, t);
    }

    float EaseOutQuad(float a, float b, float t)
    {
        t = 1 - Mathf.Pow(t - 1, 2);
        return EaseLinear(a, b, t);
    }

    float EaseInOutQuad(float a, float b, float t)
    {
        t = t <= 0.5f ? 2 * t * t : 1 - Mathf.Pow(2 * t - 2, 2) / 2;
        return EaseLinear(a, b, t);
    }

    float EaseInCub(float a, float b, float t)
    {
        t = t * t * t;
        return EaseLinear(a, b, t);
    }

    float EaseOutCub(float a, float b, float t)
    {
        t = Mathf.Pow( t - 1, 3) + 1;
        return EaseLinear(a, b, t);
    }
    
    float EaseInOutCub(float a, float b, float t)
    {
        t = t <= 0.5 ? 4 * t * t * t : 4 * Mathf.Pow(t - 1, 3) + 1;
        return EaseLinear(a, b, t);
    }

    float EaseInQuart(float a, float b, float t)
    {
        t = Mathf.Pow(t, 4);
        return EaseLinear(a, b, t);
    }

    float EaseOutQuart(float a, float b, float t)
    {
        t = 1 - Mathf.Pow(t - 1, 4);
        return EaseLinear(a, b, t);
    }

    float EaseInOutQuart(float a, float b, float t)
    {
        t = t <= 0.5f ? - 8 * Mathf.Pow(t - 0.5f, 4) + 0.5f : 8 * Mathf.Pow(t - 0.5f, 4) + 0.5f;
        return EaseLinear(a, b, t);
    }

    float EaseInQuint(float a, float b, float t)
    {
        t = Mathf.Pow( t, 5);
        return EaseLinear(a, b, t);
    }

    float EaseOutQuint(float a, float b, float t)
    {
        t = Mathf.Pow(t - 1, 5) + 1;
        return EaseLinear(a, b, t);
    }

    float EaseInOutQuint(float a, float b, float t)
    {
        t = t <= 0.5f ? 16 * Mathf.Pow(t, 5) : 16 * Mathf.Pow(t - 1, 5) + 1;;
        return EaseLinear(a, b, t);
    }
}
