using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoryBlink : MonoBehaviour
{
    [SerializeField] Text text;
    public IEnumerator Blink()
    {
        text.enabled = true;
        yield return new WaitForSeconds(1);
        text.enabled = false;
        yield return new WaitForSeconds(1);
        StartCoroutine("Blink");
    }
}
