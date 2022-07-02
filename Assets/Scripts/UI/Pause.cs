using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject PauseObject;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            DoPause();
        }
    }

    public void DoPause()
    {
        if (PauseObject.activeInHierarchy)
        {
            PauseObject.SetActive(false);
            Time.timeScale = 1;
            return;
        }
        Time.timeScale = 0;
        PauseObject.SetActive(true);
    }
}
