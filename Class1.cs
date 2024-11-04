using UnityEngine;
using MelonLoader;
using Il2Cpp;
using Il2CppDrova;
using UnityEngine.Windows;


namespace Drova_Fog_Toggle
{
    public class FogToggle : MelonMod
    {
        public GameObject fog = null;
        public override void OnInitializeMelon()
        {
            Melon<FogToggle>.Logger.Msg("Fog toggler active.");
        }
        //Floor Fog
        public override void OnLateUpdate()
        {
            bool myInput = UnityEngine.Input.GetKeyDown(KeyCode.N);
            if (myInput)
            {
                if (fog == null)
                {
                    fog = GameObject.Find("Floor Fog");
                }
                fog.SetActive(!fog.active);
            }
        }

    }
}
