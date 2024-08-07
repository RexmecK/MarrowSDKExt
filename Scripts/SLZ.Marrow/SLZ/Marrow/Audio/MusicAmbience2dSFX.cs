using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Marrow.Audio
{
	[Obsolete("MusicAmbience2dSFX has been replaced by Audio2dPlugin.Audio2dManager use that instead", true)]
	public class MusicAmbience2dSFX : MonoBehaviour
	{
		[Serializable]
		public class AmbAndMusic
		{
			public AudioSource ambMus;

			public AudioClip clip;

			public bool isFading;

			public float fadeTarget;

			public float fadePerSec;

			public void UpdateFade()
			{
			}

			public void FadeOut(float fadeOutTime)
			{
			}

			public void FadeIn(AudioClip ambClip, float fadeTar, float fadeInTime)
			{
			}

			public void AttenuateCurrent(float fadeTar, float fadeInTime)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003COverrideCallback_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float releaseTime;

			public MusicAmbience2dSFX _003C_003E4__this;

			private float _003CstopTime_003E5__2;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003COverrideCallback_003Ed__20(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003CLoopCue_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float introLength;

			public float tranFade;

			public MusicAmbience2dSFX _003C_003E4__this;

			public AudioClip loop;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CLoopCue_003Ed__26(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003CCoFadeReverbData_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float fadeTime;

			public MusicAmbience2dSFX _003C_003E4__this;

			private float _003CstartTime_003E5__2;

			private float _003CendTime_003E5__3;

			private float _003ClerpPerc_003E5__4;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CCoFadeReverbData_003Ed__35(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		public AmbAndMusic[] ambAndMusics;

		public AudioMixerGroup AmbientMixerGroup;

		public AudioMixerGroup MusicMixerGroup;

		private int _curAmb;

		private int _curMus;

		private Coroutine _loopPending;

		private bool _isOverride;

		private bool _overridenHasIntro;

		private AudioClip _overridenMusicClip;

		private float _overridenTargetVol;

		private float _overridenFadeInTime;

		private float _overridenFadeOutTime;

		private bool _overridenLoop;

		private AudioClip _overridenMusicIntro;

		private float _overridenLoopTransitionFade;

		private IEnumerator _overrideCallback;

		private float[] tempData;

		private float minFadeTime;

		private Coroutine fadeRoutine;

		public AudioMixer mixer;

		public AudioReverbData prevReverbObj;

		public AudioReverbData reverbObj;

		private void Awake()
		{
		}

		public void CueOverrideMusic(AudioClip musicClip, float targetVol, float fadeInTime, float fadeOutTime, bool loop = true, bool timedRelease = true)
		{
		}

		public void StopOverrideMusic(AudioClip musicClip, float fadeOutTime)
		{
		}

		[IteratorStateMachine(typeof(_003COverrideCallback_003Ed__20))]
		private IEnumerator OverrideCallback(float releaseTime)
		{
			return null;
		}

		public void CueAmbience(AudioClip ambienceClip, float targetVol, float fadeInTime, float fadeOutTime)
		{
		}

		public void CueMusic(AudioClip musicClip, float targetVol, float fadeInTime, float fadeOutTime, bool loop = true)
		{
		}

		public void CueMusicLoopWithIntro(AudioClip musicIntro, AudioClip musicLoop, float targetVol, float fadeInTime, float fadeOutTime, float loopTransitionFade)
		{
		}

		public void StopMusic(AudioClip musicClip, float fadeOutTime)
		{
		}

		private void Update()
		{
		}

		[IteratorStateMachine(typeof(_003CLoopCue_003Ed__26))]
		private IEnumerator LoopCue(AudioClip loop, float introLength, float tranFade)
		{
			return null;
		}

		public float GetParamVal(string name, float value)
		{
			return 0f;
		}

		public void FadeToNewReverb(AudioReverbData reverbData)
		{
		}

		[IteratorStateMachine(typeof(_003CCoFadeReverbData_003Ed__35))]
		private IEnumerator CoFadeReverbData(float fadeTime)
		{
			return null;
		}

		private void StopFadeRoutine()
		{
		}
	}
}
