using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LivesController : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        switch (Score.lives)
        {
            case 3:
                break;
            case 2:
                gameObject.transform.GetChild(2).gameObject.SetActive(false);
                break;
            case 1:
                gameObject.transform.GetChild(2).gameObject.SetActive(false);
                gameObject.transform.GetChild(1).gameObject.SetActive(false);
                break;
            case 0:
                //GameOverScene
                break;
            default:
                break;

        }
    }
}
