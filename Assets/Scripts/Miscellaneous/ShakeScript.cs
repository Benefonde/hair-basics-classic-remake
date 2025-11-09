using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //if (!enableShake) Destroy(this);
        rectTransform = GetComponent<RectTransform>();
        offset = transform.localPosition;
        // setting for enabling shake (i dont wanna use playerprefs)
    }

    // Update is called once per frame
    void Update()
    {
        if (delay > 0)
        {
            delay -= Time.deltaTime;
            return;
        }
        float rng1 = intensity.x * Mathf.Sign(Random.Range(-1f, 1f));
        float rng2 = intensity.y * Mathf.Sign(Random.Range(-1f, 1f));
        float rng3 = intensity.z * Mathf.Sign(Random.Range(-1f, 1f));

        if (ui)
        {
            rectTransform.anchoredPosition = offset + new Vector3(rng1, rng2, rng3); 
        }
        else
        {
            transform.localPosition = offset + new Vector3(rng1, rng2, rng3);
        }
        delay = delaySet; 
    }

    bool enableShake = true;

    public Vector3 intensity;
    public float delaySet;
    public bool ui;

    RectTransform rectTransform;
    float delay = 1/60f;
    Vector3 offset;
}
