using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PluginSampleTest : ButtonBase {

	[SerializeField] Text test_text;

	public static readonly string ANDROID_NATIVE_PLUGIN_CLASS = "com.example.unitypluginsamplelibrary.TestPlugin";

    // Start is called before the first frame update
    new void Start() {
    	base.Start();
        test_text.text = "";
    }

    public override void ButtonFunc() {
    	using (AndroidJavaClass androidJavaClass = new AndroidJavaClass(ANDROID_NATIVE_PLUGIN_CLASS)) {
    		Debug.Log("aaaa");
    		androidJavaClass.CallStatic("Execute");
    	}
    }

    public void FromAndroid(string message) {
    	Debug.Log("bbbb");
    	test_text.text = message;
    }
}
