using System;
using UnityEngine;

/*
 * Global GameManager Obj
 * Will be used for things needed such as the Logger, and more to come
 */

namespace SketchShowdown._Project.Scripts.Core
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance; // GameManager instance for Singleton
        public static Logger logger; // Logger obj to be instanced

        private void Awake()
        {
            // Checks if their is no GameManager instance, and if true creates one
            if (instance == null)
            {
                instance = this;
                logger = new Logger();
            }
        }
    }
}