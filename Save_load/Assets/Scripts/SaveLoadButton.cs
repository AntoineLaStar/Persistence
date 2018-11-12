using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadButton : MonoBehaviour {

	public void Save()
    {
        GameController.control.SaveGame();
        SceneController.sceneControl.Save();
    }

    public void Load()
    {
        GameController.control.LoadGame();
        SceneController.sceneControl.Load();
    }

}
