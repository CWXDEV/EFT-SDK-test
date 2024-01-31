using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x0200290A RID: 10506
	public sealed class TMP_FPSCounter : MonoBehaviour
	{
		// Token: 0x17002555 RID: 9557
		// (get) Token: 0x0600D1B4 RID: 53684 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D1B5 RID: 53685 RVA: 0x00002050 File Offset: 0x00000250
		public bool Active
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600D1B6 RID: 53686 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600D1B7 RID: 53687 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(int level)
		{
			throw null;
		}

		// Token: 0x0600D1B8 RID: 53688 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_0()
		{
			throw null;
		}

		// Token: 0x0600D1B9 RID: 53689 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_1()
		{
			throw null;
		}

		// Token: 0x0600D1BA RID: 53690 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_2()
		{
			throw null;
		}

		// Token: 0x0600D1BB RID: 53691 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_3()
		{
			throw null;
		}

		// Token: 0x0600D1BC RID: 53692 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x0600D1BD RID: 53693 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetPerformanceState(out double fpsMeasure, out double gameUpdate, out double renderMeasurer, out double frameMeasurer, out double diskIdleMeasurer, out double diskReadBytesMeasurer, out double diskWriteBytesMeasurer, out double localVRAMUsageMBytes, out double privateMemMBytes, out double desiredTextureMemoryMBytes, out double totalReservedMemory, out double gpuUtilization)
		{
			throw null;
		}

		// Token: 0x0600D1BE RID: 53694 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator PerformanceTest(int overall, int every, string label = "label", Action onTestComplete = null)
		{
			throw null;
		}

		// Token: 0x0600D1BF RID: 53695 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		// Token: 0x0400D2C2 RID: 53954
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x0400D2C3 RID: 53955
		[SerializeField]
		private TextMeshProUGUI _fpsCounterLabel;

		// Token: 0x0400D2C4 RID: 53956
		[SerializeField]
		private TextMeshProUGUI _fpsMaxCounterLabel;

		// Token: 0x0400D2C5 RID: 53957
		[SerializeField]
		private TextMeshProUGUI _rttTimeCounterLabel;

		// Token: 0x0400D2C6 RID: 53958
		[SerializeField]
		private TextMeshProUGUI _serverFixedUpdateCounterLabel;

		// Token: 0x0400D2C7 RID: 53959
		[SerializeField]
		private TextMeshProUGUI _serverTimeDiffCounterLabel;

		// Token: 0x0400D2C8 RID: 53960
		[SerializeField]
		private GameObject _extendedLabelsPanel;

		// Token: 0x0400D2C9 RID: 53961
		[SerializeField]
		private TextMeshProUGUI _averageFpsLabel;

		// Token: 0x0400D2CA RID: 53962
		[SerializeField]
		private TextMeshProUGUI _fixedUpdateFpsLabel;

		// Token: 0x0400D2CB RID: 53963
		[SerializeField]
		private TextMeshProUGUI _averageFixedUpdateFpsLabel;

		// Token: 0x0400D2CC RID: 53964
		[SerializeField]
		private TextMeshProUGUI _singleFixedUpdateFpsLabel;

		// Token: 0x0400D2CD RID: 53965
		[SerializeField]
		private TextMeshProUGUI _fixedUpdateBetweenUpdatesLabel;

		// Token: 0x0400D2CE RID: 53966
		[SerializeField]
		private TextMeshProUGUI _updateMeasurerLabel;

		// Token: 0x0400D2CF RID: 53967
		[SerializeField]
		private TextMeshProUGUI _gameUpdateLabel;

		// Token: 0x0400D2D0 RID: 53968
		[SerializeField]
		private TextMeshProUGUI _renderMsLabel;

		// Token: 0x0400D2D1 RID: 53969
		[SerializeField]
		private TextMeshProUGUI _frameMsLabel;

		// Token: 0x0400D2D2 RID: 53970
		[SerializeField]
		private TextMeshProUGUI _distantShadowObjectsLabel;

		// Token: 0x0400D2D3 RID: 53971
		[SerializeField]
		private TextMeshProUGUI LocalVRamTotal;

		// Token: 0x0400D2D4 RID: 53972
		[SerializeField]
		private TextMeshProUGUI LocalVRamUsage;

		// Token: 0x0400D2D5 RID: 53973
		[SerializeField]
		private TextMeshProUGUI MaxLocalVRamUsage;

		// Token: 0x0400D2D6 RID: 53974
		[SerializeField]
		private TextMeshProUGUI TotalLocalVRam;

		// Token: 0x0400D2D7 RID: 53975
		[SerializeField]
		private TextMeshProUGUI DiskUsage;

		// Token: 0x0400D2D8 RID: 53976
		[SerializeField]
		private TextMeshProUGUI DiskRead;

		// Token: 0x0400D2D9 RID: 53977
		[SerializeField]
		private TextMeshProUGUI DiskWrite;

		// Token: 0x0400D2DA RID: 53978
		[SerializeField]
		private TextMeshProUGUI VirtualMemoryBytes;

		// Token: 0x0400D2DB RID: 53979
		[SerializeField]
		private TextMeshProUGUI GpuUtilization;

		// Token: 0x0400D2DC RID: 53980
		[SerializeField]
		private TextMeshProUGUI _networkRttLabel;

		// Token: 0x0400D2DD RID: 53981
		[SerializeField]
		private TextMeshProUGUI _networkLossLabel;

		// Token: 0x0400D2DE RID: 53982
		[SerializeField]
		private TextMeshProUGUI _bufferCountLabel;

		// Token: 0x0400D2DF RID: 53983
		[SerializeField]
		private TextMeshProUGUI _cameraPositionLabel;

		// Token: 0x0400D2E0 RID: 53984
		[SerializeField]
		private TextMeshProUGUI _desiredTextureMemory;

		// Token: 0x0400D2E1 RID: 53985
		[SerializeField]
		private TextMeshProUGUI _totalMemoryReserved;

		// Token: 0x0400D2E2 RID: 53986
		[SerializeField]
		private GameObject _webSocketLabelsPanel;

		// Token: 0x0400D2E3 RID: 53987
		[SerializeField]
		private TextMeshProUGUI _webSocketConnStatus;

		// Token: 0x0400D2E4 RID: 53988
		[SerializeField]
		private TextMeshProUGUI _webSocketCloseStatusCode;

		// Token: 0x0400D2E5 RID: 53989
		[SerializeField]
		private TextMeshProUGUI _webSocketConnIsAlive;

		// Token: 0x0400D2E6 RID: 53990
		[SerializeField]
		private TextMeshProUGUI _webSocketRequestsInProgressCount;

		// Token: 0x0400D2E7 RID: 53991
		private const int int_0 = 4;

		// Token: 0x0400D2E8 RID: 53992
		private const int int_1 = 1;

		// Token: 0x0400D2E9 RID: 53993
		private const float float_0 = 0.1f;

		// Token: 0x0400D2EA RID: 53994
		private const string string_0 = "(inf)";

		// Token: 0x0400D2EB RID: 53995
		private const string string_1 = "0.00";

		// Token: 0x0400D2EC RID: 53996
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400D2ED RID: 53997
		public bool ShowGraphs;

		// Token: 0x0400D2EE RID: 53998
		private readonly List<double> list_0;

		// Token: 0x0400D2EF RID: 53999
		private GClass1150 gclass1150_0;

		// Token: 0x0400D2F0 RID: 54000
		private GInterface74 ginterface74_0;

		// Token: 0x0400D2F1 RID: 54001
		private GInterface74 ginterface74_1;

		// Token: 0x0400D2F2 RID: 54002
		private GInterface74 ginterface74_2;

		// Token: 0x0400D2F3 RID: 54003
		private GInterface74 ginterface74_3;

		// Token: 0x0400D2F4 RID: 54004
		private GInterface74 ginterface74_4;

		// Token: 0x0400D2F5 RID: 54005
		private GInterface74 ginterface74_5;

		// Token: 0x0400D2F6 RID: 54006
		private GInterface74 ginterface74_6;

		// Token: 0x0400D2F7 RID: 54007
		private GInterface74 ginterface74_7;

		// Token: 0x0400D2F8 RID: 54008
		private GInterface74 ginterface74_8;

		// Token: 0x0400D2F9 RID: 54009
		private GInterface74 ginterface74_9;

		// Token: 0x0400D2FA RID: 54010
		private GInterface74 ginterface74_10;

		// Token: 0x0400D2FB RID: 54011
		private GInterface74 ginterface74_11;

		// Token: 0x0400D2FC RID: 54012
		private GInterface74 ginterface74_12;

		// Token: 0x0400D2FD RID: 54013
		private GInterface74 ginterface74_13;

		// Token: 0x0400D2FE RID: 54014
		private bool bool_1;

		// Token: 0x0400D2FF RID: 54015
		private float float_1;

		// Token: 0x0400D300 RID: 54016
		private const float float_2 = 2f;

		// Token: 0x0400D301 RID: 54017
		private GClass1147 gclass1147_0;

		// Token: 0x0400D302 RID: 54018
		private GClass1147 gclass1147_1;

		// Token: 0x0400D303 RID: 54019
		private GClass1147 gclass1147_2;

		// Token: 0x0400D304 RID: 54020
		private GClass1147 gclass1147_3;

		// Token: 0x0400D305 RID: 54021
		private GClass1147 gclass1147_4;

		// Token: 0x0400D306 RID: 54022
		private GClass1147 gclass1147_5;

		// Token: 0x0400D307 RID: 54023
		private Mutex mutex_0;

		// Token: 0x0400D308 RID: 54024
		private TMP_FPSCounter.Class2393[] class2393_0;

		// Token: 0x0200290B RID: 10507
		private sealed class Class2393
		{
			// Token: 0x0600D1C0 RID: 53696 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Start()
			{
				throw null;
			}

			// Token: 0x0600D1C1 RID: 53697 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Stop()
			{
				throw null;
			}

			// Token: 0x0400D309 RID: 54025
			public readonly float Width;

			// Token: 0x0400D30A RID: 54026
			private readonly MonoBehaviour monoBehaviour_0;

			// Token: 0x0400D30B RID: 54027
			private readonly Func<IEnumerator> func_0;

			// Token: 0x0400D30C RID: 54028
			private Coroutine coroutine_0;
		}
	}
}
