using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using System;


public class SpawnBalls : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    
    struct FunctionPack
    {
        public Easing.Function inFunc;
        public Easing.Function outFunc;
        public Easing.Function inOutFunc;
	}
    List<FunctionPack> packs = new List<FunctionPack>();

    void Start()
    {
        float offsetX = -12f;
        float offsetY = 2;
        int width = 12;
        int paddingX = 5; //todo how to make this padding every 3rd. 
        int paddingY = -6;

        Dictionary<string, FunctionPack> dictionary = new Dictionary<string, FunctionPack>();
        var names = Enum.GetNames(typeof(Easing.Function));
        foreach(var name in names) 
        {
            if(name.Contains("InOut")) {

			}
            else if(name.Contains("In")) {

			}
            else if (name.Contains("Out")) {

            }
        }
        


        for (int i = 0; i < (int) Easing.Style.Count; i++)
        {
            GameObject temp = Instantiate(ballPrefab, transform);
            float tempX = ((transform.position.x) + i % width) * paddingX + offsetX;
            float tempY = i / width * paddingY + offsetY;

            temp.transform.position = new Vector3(tempX,  tempY, transform.position.z);
            var function = Easing.GetFunction((Easing.Style)i);
            StartCoroutine(ease(temp.transform, function, new Vector2(tempX, tempY), new Vector2(tempX + 4, tempY + 4)));
        }
    }

    IEnumerator ease(Transform that, Easing.Function func, Vector2 start, Vector2 end) 
    {
        float t = 0;

        while(t <= 1.0f) {
            Vector2 next = that.position;
            next.x = Easing.GetFunction(Easing.Style.Linear)(start.x, end.x, t);
            next.y = func(start.y, end.y, t);
            that.position = next;
            t += Time.deltaTime;
            yield return null;
		}
        that.position = end;

        StartCoroutine(ease(that, func, start, end));
	}

}
