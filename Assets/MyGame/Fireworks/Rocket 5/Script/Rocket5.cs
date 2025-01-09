using UnityEngine;

public class Rocket5 : MonoBehaviour
{
    public Rigidbody rig; 
    public ConstantForce cf; 
    public Transform rocketTransform; 
    public string launchTime; 
    public float explosionDelay = 5f; 

    private bool hasLaunched = false;
    private float launchTimestamp = 0; 

    void Start()
    {
        // Rakete zu Beginn deaktivieren
        rig.isKinematic = true;
        cf.enabled = false;
    }

    void Update()
    {
        string currentTime = System.DateTime.Now.ToString("HH:mm:ss");

        if (!hasLaunched && currentTime == launchTime)
        {
            LaunchRocket();
        }

        if (hasLaunched && Time.time >= launchTimestamp + explosionDelay)
        {
            ExplodeRocket();
        }
    }

    void LaunchRocket()
    {
        Debug.Log("Rakete gestartet um " + System.DateTime.Now.ToString("HH:mm:ss"));
        rig.isKinematic = false;
        cf.enabled = true;
        launchTimestamp = Time.time;
        hasLaunched = true;
    }

    void ExplodeRocket()
    {
        Debug.Log("Rakete explodiert!");
        rocketTransform.localScale *= 3.0f;
        rig.isKinematic = true;
        cf.enabled = false;

        Destroy(gameObject, 2.0f);
    }
}
