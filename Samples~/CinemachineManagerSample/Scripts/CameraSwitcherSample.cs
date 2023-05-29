using UnityEngine;

namespace TJ.Utils.CineCameraManager
{
    public class CameraSwitcherSample : MonoBehaviour
    {
        public void EnableCamera(int num)
        {
            CineCameraManager.Instance.SwitchTo(num);
        }
    }
}

