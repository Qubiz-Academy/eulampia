using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject CompleteLevelUI;
    // Use this for initialization

    private void OnTriggerEnter(Collider other)
    {
        CompleteLevelUI.SetActive(true);
    }

    // Update is called once per frame
}
