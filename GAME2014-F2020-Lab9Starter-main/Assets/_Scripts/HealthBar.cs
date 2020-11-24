using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class HealthBar : MonoBehaviour
{
    public Transform bar;

    public int value = 100;
    public Transform character;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        transform.position = character.position + new Vector3(0, 0.8f, 0.0f);
    }

    public void SetValue(int new_Value)
    {
        value = new_Value;
        bar.localScale = new Vector3(value / 100.0f, 1.0f, 1.0f);

        if (bar.localScale.x <= 0)
        {
            bar.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }
    }
}
