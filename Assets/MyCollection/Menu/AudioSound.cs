
using UnityEngine;
using UnityEngine.UI;
using System.Collections;


namespace StartGameDev
{

    public class AudioSound : MonoBehaviour
    {

        public Slider slider;
        public Text valueCount;

        
        void Update()
        {

            valueCount.text = slider.value.ToString();
            AudioListener.volume = slider.value / 100;
        }
        /*
        public void sliderevent(Slider slider_sounder)
        {
            valueCount.text = slider_sounder.value.ToString();
            AudioListener.volume = slider_sounder.value / 100;
        }*/
    }

}