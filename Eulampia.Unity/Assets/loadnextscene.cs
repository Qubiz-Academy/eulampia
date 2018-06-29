
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadnextscene : MonoBehaviour {

	public void Loadnextscene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
