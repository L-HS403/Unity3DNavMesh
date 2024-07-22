using UnityEngine;

public class Pause : MonoBehaviour
{
    private float fixedDeltaTime;

    void Awake()
    {
        this.fixedDeltaTime = Time.fixedDeltaTime;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Time.timeScale == 1.0f)
            {
                Debug.Log("Pause");
                Time.timeScale = 0f;
            }

            else
            {
                Time.timeScale = 1.0f;
                Debug.Log("Resume");
            }

            Time.fixedDeltaTime = this.fixedDeltaTime * Time.timeScale;
        }
    }
}
