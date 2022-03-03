using UnityEngine;

/*
 * Base Logger Object, will use to log info to the Unity Console
 * In its own class in case more features are needed
 * Will be used as a Singleton
 */
namespace SketchShowdown._Project.Scripts.Core
{
    public class Logger
    {
        private bool toggled; // For checking if all Console msgs are to be logged
        
        public void Log(object message)
        {
            if (this.toggled)
            {
                Debug.Log(message);
            }
        }
    }
}