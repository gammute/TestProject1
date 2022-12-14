using UnityEngine;
using UnityEngine.Events;

namespace Sortitems
{
    public class CharacterActivatorCanvas : MonoBehaviour
    {
        public UnityEvent SceneActive;

        public void OnEnable()
        {
            SceneActive.Invoke();
        }
    }
}
