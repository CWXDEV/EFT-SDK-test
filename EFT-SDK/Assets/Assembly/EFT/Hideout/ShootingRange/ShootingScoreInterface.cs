using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

namespace EFT.Hideout.ShootingRange
{
	// Token: 0x02001C0C RID: 7180
	public class ShootingScoreInterface : MonoBehaviour
	{
		// Token: 0x060096A4 RID: 38564 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task StartBeforeTraining(int seconds, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x060096A5 RID: 38565 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task StartTraining(int seconds, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x060096A6 RID: 38566 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartCountdown(float delay, float duration)
		{
			throw null;
		}

		// Token: 0x060096A7 RID: 38567 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopCountdown()
		{
			throw null;
		}

		// Token: 0x060096A8 RID: 38568 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetCountdown()
		{
			throw null;
		}

		// Token: 0x060096A9 RID: 38569 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowBeforeTraining()
		{
			throw null;
		}

		// Token: 0x060096AA RID: 38570 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowTraining()
		{
			throw null;
		}

		// Token: 0x060096AB RID: 38571 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCountdown(int value)
		{
			throw null;
		}

		// Token: 0x060096AC RID: 38572 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowTimeLeft()
		{
			throw null;
		}

		// Token: 0x060096AD RID: 38573 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideTimeLeft()
		{
			throw null;
		}

		// Token: 0x060096AE RID: 38574 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTimeLeft(int value)
		{
			throw null;
		}

		// Token: 0x060096AF RID: 38575 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTimeLeftColor(Color value)
		{
			throw null;
		}

		// Token: 0x060096B0 RID: 38576 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBestScore(int value)
		{
			throw null;
		}

		// Token: 0x060096B1 RID: 38577 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCurrentScore(int value)
		{
			throw null;
		}

		// Token: 0x060096B2 RID: 38578 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string FormatScore(int value)
		{
			throw null;
		}

		// Token: 0x060096B3 RID: 38579 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string FormatTime(int value)
		{
			throw null;
		}

		// Token: 0x060096B4 RID: 38580 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string FormatSeconds(int value)
		{
			throw null;
		}

		// Token: 0x04009D9C RID: 40348
		[SerializeField]
		private GameObject _beforeTraining;

		// Token: 0x04009D9D RID: 40349
		[SerializeField]
		private GameObject _training;

		// Token: 0x04009D9E RID: 40350
		[SerializeField]
		private TextMeshProUGUI _countdownValue;

		// Token: 0x04009D9F RID: 40351
		[SerializeField]
		private Color _defaultCountdownColor;

		// Token: 0x04009DA0 RID: 40352
		[SerializeField]
		private Color _finalCountdownColor;

		// Token: 0x04009DA1 RID: 40353
		[SerializeField]
		private int _finalCountdownSeconds;

		// Token: 0x04009DA2 RID: 40354
		[SerializeField]
		private GameObject _timeLeft;

		// Token: 0x04009DA3 RID: 40355
		[SerializeField]
		private TextMeshProUGUI _timeLeftValue;

		// Token: 0x04009DA4 RID: 40356
		[SerializeField]
		private TextMeshProUGUI _currentScoreValue;

		// Token: 0x04009DA5 RID: 40357
		[SerializeField]
		private TextMeshProUGUI _bestScoreValue;

		// Token: 0x04009DA6 RID: 40358
		[SerializeField]
		private AudioSource _audioSignal;

		// Token: 0x04009DA7 RID: 40359
		private Color color_0;

		// Token: 0x04009DA8 RID: 40360
		private CancellationTokenSource cancellationTokenSource_0;
	}
}
