using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBase : MonoBehaviour {

	Button button;

    // Start is called before the first frame update
    public void Start() {
        button = GetComponent<Button>();
        button.onClick.AddListener(ButtonFunc);
    }

    public virtual void ButtonFunc() {

    }
}
