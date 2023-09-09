using System.Collections;
using System.Collections.Generic;
using Photon.Voice.Unity;
using UnityEngine;
using UnityEngine.UI;

public class PushToTalk : MonoBehaviour
{
    private Recorder recorder;

    public Image greenIndicator; // Tambahkan variabel untuk indikator warna hijau
    public Image redIndicator;   // Tambahkan variabel untuk indikator warna merah

    private bool isRecording = false;

    // Start is called before the first frame update
    void Awake()
    {
        if (recorder == null)
        {
            recorder = GetComponent<Recorder>();
        }

        recorder.TransmitEnabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            recorder.TransmitEnabled = true;
            // Atur indikator warna hijau aktif dan indikator warna merah nonaktif
            greenIndicator.gameObject.SetActive(true);
            redIndicator.gameObject.SetActive(false);
            isRecording = true;
        }
        else if (Input.GetKeyUp(KeyCode.T))
        {
            recorder.TransmitEnabled = false;
            // Atur indikator warna merah aktif dan indikator warna hijau nonaktif
            greenIndicator.gameObject.SetActive(false);
            redIndicator.gameObject.SetActive(true);
            isRecording = false;
        }

        if (recorder.VoiceDetector.Detected)
        {
            print("Voice Detected");
        }
    }
}
