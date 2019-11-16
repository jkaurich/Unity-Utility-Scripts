using UnityEngine;

public abstract class AbstractSingleton<T> : MonoBehaviour where T : MonoBehaviour {

  // Singleton instance
  private static T instance;

  // Singleton instance accessor
  public static T Instance { get { return instance; } }

  // Awake is called when the script instance is being loaded
  protected virtual void Awake() {
    if ( instance != null ) {
      Destroy(gameObject);
      return;
    } else {
      instance = this as T;
    }
  }
}