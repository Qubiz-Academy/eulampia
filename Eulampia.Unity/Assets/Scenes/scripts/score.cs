
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour {



    public Transform player;
    public Text scoreText;
    public float maxim = 0;
    // Update is called once per frame
    void Update()
    {
        if(player.position.x > maxim)
        {
            scoreText.text = player.position.x.ToString("0");
            maxim = player.position.x;
        }
    }
}

