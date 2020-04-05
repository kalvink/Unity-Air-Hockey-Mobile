using UnityEngine;
using UnityEngine.SceneManagement;

//Change scenes

public class ChangeScene : MonoBehaviour {

        public void ChangeToScene(int sceneToChangeTo) {
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
            }
            SceneManager.LoadScene(sceneToChangeTo);
        }

}
