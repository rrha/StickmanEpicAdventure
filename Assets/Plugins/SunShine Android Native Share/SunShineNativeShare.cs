using UnityEngine;


public class SunShineNativeShare : MonoBehaviour
{


    public static string TYPE_IMAGE = "image/*";



    private const string SHARE_PACKAGE_NAME = "com.SmileSoft.unityplugin";
    private const string SHARE_CLASS_NAME = ".ShareFragment";
    private const string TEXT_SHARE_METHOD = "ShareText";
    private const string SINGLE_FILE_SHARE_METHOD = "ShareSingleFile";


    private const string FileProviderName = "com.rahimgames.stickmanepicadventure";



    public static void ShareText(string message, string shareDialogTitle)
    {

#if UNITY_ANDROID
        using (AndroidJavaObject share_android_obj = new AndroidJavaObject(SHARE_PACKAGE_NAME + SHARE_CLASS_NAME))
        {
            share_android_obj.Call(TEXT_SHARE_METHOD, message, shareDialogTitle);

        }
#endif
        Debug.Log("Native Share just work in android Platform");


    }

    public static void ShareSingleFile(string path, string fileType, string message, string shareDialogTitle)
    {
#if UNITY_ANDROID
        using (AndroidJavaObject share_android_obj = new AndroidJavaObject(SHARE_PACKAGE_NAME + SHARE_CLASS_NAME))
        {
            share_android_obj.Call(SINGLE_FILE_SHARE_METHOD, FileProviderName, path, fileType, message, shareDialogTitle);
        }

#endif
        Debug.Log("Native Share just work in android Platform");
    }




}
