using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public Camera[] cameras;
    public AudioListener[] camerasListener;

    public void switchCameras()
    {
        int cameraCounter = PlayerPrefs.GetInt("CameraPosition");
        cameraCounter++;
        if(cameraCounter > 1)
        {
            cameraCounter = 0;
        }
        PlayerPrefs.SetInt("CameraPosition", cameraCounter);

        cameras[cameraCounter].enabled = true;
        camerasListener[cameraCounter].enabled = true;
        cameras[1 - cameraCounter].enabled = false;
        camerasListener[1 - cameraCounter].enabled = false;
    }
   
}
