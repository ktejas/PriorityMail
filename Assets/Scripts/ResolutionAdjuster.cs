using UnityEngine;
using System.Collections;

public class ResolutionAdjuster : MonoBehaviour
{

    void Start()
    {
        AdjustCamera();
    }

    void AdjustCamera()
    {
        float aspect = (float)Screen.width / (float)Screen.height;

        if (aspect < 1.51f)
        {
            Camera.main.orthographicSize = 3.6f;
        }
        else
        {
            Camera.main.orthographicSize = 3.2f;
        }
    }
}
