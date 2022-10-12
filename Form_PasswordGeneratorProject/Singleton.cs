using System;

namespace Form_PasswordGeneratorProject {
    public abstract class Singleton<T> where T : Singleton<T>, new() {
        private static T _instance = new T();
        
        private static readonly object padlock = new object();
        
        public static T Instance {
            get {
                lock (padlock) {
                    if (_instance == null)
                    {
                        _instance = new T();
                        
                    }
                    return _instance;

                }
            }
        }
    }
}