using System.Collections;
using UnityEngine;
using TMPro; 

public class TestTimer: MonoBehaviour
{
    public TMP_Text textMeshPro;
    void Start()
    {
        // Startet die Zeitaktualisierung
        StartCoroutine(UpdateTimeCoroutine());
    }

    IEnumerator UpdateTimeCoroutine()
    {
        while (true)
        {
            var today = System.DateTime.Now;
            textMeshPro.text = today.ToString("yyyy-MM-dd  HH:mm:ss");
            // Wartet 0,2 Sekunden, bevor es erneut aktualisiert
            yield return new WaitForSeconds(0.2f);
        }
    }
}
