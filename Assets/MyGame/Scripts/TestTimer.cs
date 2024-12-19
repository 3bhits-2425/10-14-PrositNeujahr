using System.Collections;
using UnityEngine;
using TMPro; // Namespace f�r TextMeshPro

public class TestTimer: MonoBehaviour
{
    public TMP_Text textMeshPro; // Verkn�pftes TextMeshPro-Element f�r die Anzeige

    void Start()
    {
        // Startet die Zeitaktualisierung
        StartCoroutine(UpdateTimeCoroutine());
    }

    IEnumerator UpdateTimeCoroutine()
    {
        while (true)
        {
            // Holt das aktuelle Datum und die Uhrzeit
            var today = System.DateTime.Now;
            // Aktualisiert den Text im TextMeshPro-Element
            textMeshPro.text = today.ToString("yyyy-MM-dd  HH:mm:ss");
            // Wartet 0,2 Sekunden, bevor es erneut aktualisiert
            yield return new WaitForSeconds(0.2f);
        }
    }
}
