using UnityEngine;

namespace Terkoiz.Freecam
{
    public class Program
    {
        private static GameObject HookObject;

        static void Main(string[] args)
        {
            Debug.LogError("Terkoiz.Freecam: Loading...");
            HookObject = new GameObject();
            HookObject.AddComponent<FreecamController>();
            Object.DontDestroyOnLoad(HookObject);
        }
    }
}
