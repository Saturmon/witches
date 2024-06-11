using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    // Start is called before the first frame update
    public Protagonista player;

    void Update()
    {
        if (player != null)
        {
            Vector2 newCamPosition = new Vector2(player.transform.position.x, 0);
            transform.position = new Vector3(newCamPosition.x, transform.position.y, transform.position.z);
        }
    }
}
