using UnityEngine;

public class PanteonAkademi : MonoBehaviour
{
    [SerializeField]
    private float SlowMotionSpeed = 0.25f;
    void Start()
    {
        Time.timeScale = SlowMotionSpeed;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
    }

    
}

