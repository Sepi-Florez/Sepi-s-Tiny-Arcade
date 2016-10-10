using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {
    Animator menuAnim;
    GameObject currMenu;

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
}
