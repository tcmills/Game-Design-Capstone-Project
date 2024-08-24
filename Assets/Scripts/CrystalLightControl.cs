using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CrystalLightControl : MonoBehaviour
{

    private Light light;
    private float minIntensity = -1.0f;
    private float maxIntensity = 5.0f;
    private float lerpVal = 0.0f;
    private bool pointerOn = false;

    public SpellManager spellManager;

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
    }

    private void Update()
    {

        if (!spellManager.canSubmit)
        {
            if (!pointerOn)
            {
                light.intensity = Mathf.Lerp(minIntensity, maxIntensity, lerpVal);

                lerpVal += 0.4f * Time.deltaTime;
            }
            else
            {
                light.intensity = 5.0f;
            }
        }
        else
        {
            lerpVal = 0.0f;
            minIntensity = -1.0f;
            maxIntensity = 5.0f;
            light.intensity = 0.0f;
            gameObject.SetActive(false);
        }


        if (lerpVal > 1.0f)
        {
            var temp = maxIntensity;
            maxIntensity = minIntensity;
            minIntensity = temp;
            lerpVal = 0.0f;
        }
  
    }

    public void SetPointerOn(bool set)
    {
        pointerOn = set;
    }
}
