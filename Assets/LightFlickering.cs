using UnityEngine;

public class LightFlickering : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Light myLight;
    private float interval = 2;
    float timer;

    void Start() {
        // myLight.enabled = false;
    }
    void Update() {
        timer += Time.deltaTime;
        Debug.Log(timer);
        if(timer > interval) {
            myLight.enabled = !myLight.enabled;
            interval = Random.Range(0.4f, 2f);
            timer = 0;
        }
    }
}
