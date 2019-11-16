using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour {

  protected static T instance;

  public static T Instance { get { return instance; } }

  protected virtual void CheckExistance() {
    if ( instance != null ) {
      Destroy(gameObject);
      return;
    } else {
      instance = this as T;
    }
  }

  protected virtual void Awake() {
    CheckExistance();
  }
}