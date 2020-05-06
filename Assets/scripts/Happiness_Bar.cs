using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Happiness_Bar : MonoBehaviour
{

    private Transform happiness;
    // Start is called before the first frame update
    void Start()
    {
        happiness = transform.Find("Sprite");
    }

    public void SetSize(float sizeNormalized)
    {
        happiness.localScale = new Vector3(sizeNormalized, 1f);
    }
}
