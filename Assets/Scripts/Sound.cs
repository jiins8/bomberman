using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
  public Sprite soundOnImage;
  public Sprite soundOffImage;
  

  public Button button;
  private bool isOn = true;

  public AudioSource audioSource;

  private void Start() {
    
    soundOnImage = button.image.sprite;
  }

  public void ButtonIsClicked(){
    if (isOn){
        button.image.sprite = soundOffImage;
        isOn = false;
        audioSource.mute = true;
    }
    else {
        button.image.sprite = soundOnImage;
        isOn = true;
        audioSource.mute = false;
    }
  }
}
