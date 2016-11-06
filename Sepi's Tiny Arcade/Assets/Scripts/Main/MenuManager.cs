using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class MenuManager : MonoBehaviour {
    Animator menuAnim;
    GameObject currMenu;

    public enum Events {Quit, Scene}

    void Start() {
        currMenu = transform.FindChild("Menus").FindChild("MainMenu").gameObject;
        menuAnim = currMenu.GetComponent<Animator>();
        menuAnim.SetBool("IsOpen", true);
    }

    public void ChangeMenu(GameObject menu) {
        menuAnim.SetBool("IsOpen", false);
        menuAnim = menu.GetComponent<Animator>();
        menuAnim.SetBool("IsOpen", true);
        currMenu = menu;
    }
    public void Update() {
        if (Input.GetButtonDown("Cancel")) {
            ChangeMenu(transform.FindChild("Menus").FindChild("MainMenu").gameObject);
        }
    }
    public void MenuEvent (int option) {
        switch (option){
            case 0 :
                Application.Quit();
                break;

        }
    }
    public void LoadScene (string scene) {
        SceneManager.LoadScene(scene);
    }
}
