using UnityEngine;

namespace RedShoreGames.Utils
{
    public static class RSGDebug
    {
        [System.Diagnostics.Conditional("ENABLE_LOG")]
        public static void Log(string message)
        {
            Debug.Log(message);
        }
        
        [System.Diagnostics.Conditional("ENABLE_LOG")]
        public static void LogWarning(string message)
        {
            Debug.LogWarning(message);
        }
        
        [System.Diagnostics.Conditional("ENABLE_LOG")]
        public static void LogError(string message)
        {
            Debug.LogError(message);
        }
    }
}