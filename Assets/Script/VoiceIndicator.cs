// using System.Collections;
// using System.Collections.Generic;
// using Fusion;
// using UnityEngine;
// using UnityEngine.UI;

// public class VoiceIndicator : MonoBehaviour
// {
//     public Image speakingIndicator;

//     [Networked(OnChanged = nameof(UpdateSpeakingIndicator))] public NetworkBool isSpeaking { get; set; }

//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }

//     protected static void UpdateSpeakingIndicator(Changed<VoiceIndicator> changed)
//     {
//         bool _isSpeaking = changed.Behaviour.isSpeaking;
//         Image _speakingIndicator = changed.Behaviour.speakingIndicator;

//         if(_isSpeaking)
//         {
//             _speakingIndicator.enabled = true;
//         }
//         else
//         {
//             _speakingIndicator.enabled = false;
//         }
//     }
// }
