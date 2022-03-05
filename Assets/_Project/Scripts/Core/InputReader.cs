using _Project.Controls;
using UnityEngine;

/*
 *  Will use as a relay to other scripts that need input via C# Delegates/Events
 */
namespace _Project.Scripts.Core
{
    public class InputReader : MonoBehaviour
    {
        private PlayerControls _playerControls;
        private void Awake()
        {
            _playerControls = new PlayerControls();
        }
    }
}
