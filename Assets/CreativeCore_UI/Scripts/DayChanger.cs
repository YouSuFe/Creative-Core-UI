using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DayChanger : MonoBehaviour
{
    public Light dayLight;
    // Start is called before the first frame update
    void Start()
    {
        dayLight = GameObject.Find("Directional Light").GetComponent<Light>();
    }

    public void OnDayButtonClicked()
    {
        dayLight.transform.rotation = Quaternion.Euler(new Vector3(50, -30, 0));
    }

    public void OnNightButtonClicked()
    {
        dayLight.transform.rotation = Quaternion.Euler(new Vector3(-10, 289, 256));
    }
}
