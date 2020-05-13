using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AndroidNativeManager : ButtonBase {
    [SerializeField] Text test_text, call_count_text, from_android_text;

	int call_count, from_android_count;

	public static readonly string ANDROID_NATIVE_PLUGIN_CLASS = "com.example.unitypluginsamplelibrary.TestPlugin";

    // Start is called before the first frame update
    new void Start() {
    	base.Start();
        test_text.text = "";
		call_count = 0;
		from_android_count = 0;
    }

    public override void ButtonFunc() {
#if UNITY_ANDROID
		AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		// AndroidJavaObject currentUnityActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");

		// AndroidJavaObject mObject = new AndroidJavaObject(ANDROID_NATIVE_PLUGIN_CLASS, currentUnityActivity);
		AndroidJavaClass mClass = new AndroidJavaClass(ANDROID_NATIVE_PLUGIN_CLASS);
		string str = mClass.CallStatic<string>("func", "aaa");
		Debug.Log("str:" + str);
    	// using (AndroidJavaClass androidJavaClass = new AndroidJavaClass(ANDROID_NATIVE_PLUGIN_CLASS)) {
		// 	call_count_text.text = call_count.ToString();
		// 	call_count++;
    	// 	Debug.Log("cccc");
    	// 	androidJavaClass.CallStatic("Execute");
    	// }
#endif
    }

    public void FromAndroid(string message) {
    	Debug.Log("cccc");
		from_android_text.text = from_android_count.ToString();
		from_android_count++;
    	test_text.text = message;
    }
}
