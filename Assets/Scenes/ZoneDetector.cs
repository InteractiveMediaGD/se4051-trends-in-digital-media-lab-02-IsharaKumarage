using UnityEngine;

public class ZoneDetector : MonoBehaviour
{
    public Light alertLight;
    public AudioSource alertAudio;

    public Color normalColor = Color.white;
    public Color alertColor = Color.red;

    public bool enableDebug = true;

    void Start()
    {
        if (alertLight != null)
            alertLight.color = normalColor;
    }

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        Debug.Log("Player entered");

        if (alertLight != null)
            alertLight.color = alertColor;

        if (alertAudio != null && !alertAudio.isPlaying)
            alertAudio.Play();
    }

    void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        Debug.Log("Player exited");

        if (alertLight != null)
            alertLight.color = normalColor;

        if (alertAudio != null && alertAudio.isPlaying)
            alertAudio.Stop();
    }
}