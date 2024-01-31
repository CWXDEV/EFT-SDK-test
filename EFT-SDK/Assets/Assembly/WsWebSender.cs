using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using WebSocketSharp;

// Token: 0x02000593 RID: 1427
internal class WsWebSender : MonoBehaviour
{
	// Token: 0x17000638 RID: 1592
	// (get) Token: 0x060021AA RID: 8618 RVA: 0x00002050 File Offset: 0x00000250
	public WsConnectionStatus ConnectionStatus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000639 RID: 1593
	// (get) Token: 0x060021AB RID: 8619 RVA: 0x00002050 File Offset: 0x00000250
	public CloseStatusCode CloseStatusCode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700063A RID: 1594
	// (get) Token: 0x060021AC RID: 8620 RVA: 0x00002050 File Offset: 0x00000250
	public bool DebugLastPingResult
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700063B RID: 1595
	// (get) Token: 0x060021AD RID: 8621 RVA: 0x00002050 File Offset: 0x00000250
	public bool DebugIsPingResultOutdated
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700063C RID: 1596
	// (get) Token: 0x060021AE RID: 8622 RVA: 0x00002050 File Offset: 0x00000250
	public int DebugCurrRunningRequestsCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700063D RID: 1597
	// (get) Token: 0x060021AF RID: 8623 RVA: 0x00002050 File Offset: 0x00000250
	public int DebugCurrSerializingReqs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700063E RID: 1598
	// (get) Token: 0x060021B0 RID: 8624 RVA: 0x00002050 File Offset: 0x00000250
	public int DebugCurrSendingReqs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700063F RID: 1599
	// (get) Token: 0x060021B1 RID: 8625 RVA: 0x00002050 File Offset: 0x00000250
	public int DebugCurrWaitingResponseReqs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000640 RID: 1600
	// (get) Token: 0x060021B2 RID: 8626 RVA: 0x00002050 File Offset: 0x00000250
	public float DebugCurrReconnectIntervalTimer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000641 RID: 1601
	// (get) Token: 0x060021B3 RID: 8627 RVA: 0x00002050 File Offset: 0x00000250
	public bool DebugReqConfirmInProgress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000642 RID: 1602
	// (get) Token: 0x060021B4 RID: 8628 RVA: 0x00002050 File Offset: 0x00000250
	private bool Boolean_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060021B5 RID: 8629 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task EstablishConnection(Struct32 connParams)
	{
		throw null;
	}

	// Token: 0x060021B6 RID: 8630 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task CloseConnection()
	{
		throw null;
	}

	// Token: 0x060021B7 RID: 8631 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<GClass560> SendRequest(GClass559 requestJson, int timeoutSeconds)
	{
		throw null;
	}

	// Token: 0x060021B8 RID: 8632 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddNotificationToHandle(string notificationId, Action<string> action)
	{
		throw null;
	}

	// Token: 0x060021B9 RID: 8633 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveHandlingNotification(string notificationId)
	{
		throw null;
	}

	// Token: 0x060021BA RID: 8634 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task SendNotification(GClass559 requestJson)
	{
		throw null;
	}

	// Token: 0x060021BB RID: 8635 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_0(CancellationToken cancellationToken)
	{
		throw null;
	}

	// Token: 0x060021BC RID: 8636 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_1(CancellationToken cancellationToken)
	{
		throw null;
	}

	// Token: 0x060021BD RID: 8637 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_2(CancellationToken cancellationToken)
	{
		throw null;
	}

	// Token: 0x060021BE RID: 8638 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_3(CancellationToken cancellationToken)
	{
		throw null;
	}

	// Token: 0x060021BF RID: 8639 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_4(CancellationToken cancellationToken)
	{
		throw null;
	}

	// Token: 0x060021C0 RID: 8640 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_5(GClass562 reqToSend, CancellationToken cancellationToken)
	{
		throw null;
	}

	// Token: 0x060021C1 RID: 8641 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_6(GClass562 reqToSend, CancellationToken cancellationToken)
	{
		throw null;
	}

	// Token: 0x060021C2 RID: 8642 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_7(GClass562 reqToSend, CancellationToken cancellationToken)
	{
		throw null;
	}

	// Token: 0x060021C3 RID: 8643 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<bool> method_8(GClass562 requestToSend)
	{
		throw null;
	}

	// Token: 0x060021C4 RID: 8644 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_9(GClass562 req)
	{
		throw null;
	}

	// Token: 0x060021C5 RID: 8645 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_10(object sender, MessageEventArgs e)
	{
		throw null;
	}

	// Token: 0x060021C6 RID: 8646 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_11(Func<bool> updateContinueCondition, CancellationToken cancellationToken)
	{
		throw null;
	}

	// Token: 0x060021C7 RID: 8647 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_12()
	{
		throw null;
	}

	// Token: 0x060021C8 RID: 8648 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass562 method_13()
	{
		throw null;
	}

	// Token: 0x060021C9 RID: 8649 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_14(GClass562 req)
	{
		throw null;
	}

	// Token: 0x060021CA RID: 8650 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_15()
	{
		throw null;
	}

	// Token: 0x060021CB RID: 8651 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<bool> method_16()
	{
		throw null;
	}

	// Token: 0x060021CC RID: 8652 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<bool> method_17(float outdateIntervalSec)
	{
		throw null;
	}

	// Token: 0x060021CD RID: 8653 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_18(object sender, EventArgs e)
	{
		throw null;
	}

	// Token: 0x060021CE RID: 8654 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_19(object sender, CloseEventArgs e)
	{
		throw null;
	}

	// Token: 0x060021CF RID: 8655 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_20(object sender, MessageEventArgs e)
	{
		throw null;
	}

	// Token: 0x060021D0 RID: 8656 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_21(object sender, ErrorEventArgs e)
	{
		throw null;
	}

	// Token: 0x060021D1 RID: 8657 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_22(LogData data, string message)
	{
		throw null;
	}

	// Token: 0x060021D2 RID: 8658 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<bool> DebugPingManuallyAsync()
	{
		throw null;
	}

	// Token: 0x060021D3 RID: 8659 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_23()
	{
		throw null;
	}

	// Token: 0x060021D4 RID: 8660 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_24()
	{
		throw null;
	}

	// Token: 0x060021D5 RID: 8661 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_25()
	{
		throw null;
	}

	// Token: 0x04002086 RID: 8326
	private const int int_0 = 1000;

	// Token: 0x04002087 RID: 8327
	private const int int_1 = 2000;

	// Token: 0x04002088 RID: 8328
	private const float float_0 = 1f;

	// Token: 0x04002089 RID: 8329
	private const float float_1 = 1f;

	// Token: 0x0400208A RID: 8330
	private readonly float[] float_2;

	// Token: 0x0400208B RID: 8331
	private const float float_3 = 30f;

	// Token: 0x0400208C RID: 8332
	private WsConnectionStatus wsConnectionStatus_0;

	// Token: 0x0400208D RID: 8333
	private CloseStatusCode closeStatusCode_0;

	// Token: 0x0400208E RID: 8334
	private CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x0400208F RID: 8335
	private bool bool_0;

	// Token: 0x04002090 RID: 8336
	private DateTime dateTime_0;

	// Token: 0x04002091 RID: 8337
	private float float_4;

	// Token: 0x04002092 RID: 8338
	private float[] float_5;

	// Token: 0x04002093 RID: 8339
	private bool bool_1;

	// Token: 0x04002094 RID: 8340
	private int int_2;

	// Token: 0x04002095 RID: 8341
	private float float_6;

	// Token: 0x04002096 RID: 8342
	private WebSocket webSocket_0;

	// Token: 0x04002097 RID: 8343
	private readonly Dictionary<string, Action<string>> dictionary_0;

	// Token: 0x04002098 RID: 8344
	private readonly Stack<GClass562> stack_0;

	// Token: 0x04002099 RID: 8345
	private readonly GClass563 gclass563_0;

	// Token: 0x0400209A RID: 8346
	private readonly GClass563 gclass563_1;

	// Token: 0x0400209B RID: 8347
	private readonly Dictionary<string, GClass562> dictionary_1;

	// Token: 0x0400209C RID: 8348
	private readonly List<string> list_0;

	// Token: 0x0400209D RID: 8349
	private readonly float[] float_7;

	// Token: 0x0400209E RID: 8350
	private Action action_0;

	// Token: 0x02000594 RID: 1428
	[CompilerGenerated]
	private sealed class Class276
	{
		// Token: 0x060021D6 RID: 8662 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1()
		{
			throw null;
		}

		// Token: 0x0400209F RID: 8351
		public WsWebSender wsWebSender_0;

		// Token: 0x040020A0 RID: 8352
		public DateTime startTime;
	}

	// Token: 0x020005A0 RID: 1440
	[CompilerGenerated]
	private sealed class Class277
	{
		// Token: 0x060021EE RID: 8686 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0()
		{
			throw null;
		}

		// Token: 0x040020DE RID: 8414
		public GClass562 reqToSend;

		// Token: 0x040020DF RID: 8415
		public Func<bool> func_0;
	}

	// Token: 0x020005A2 RID: 1442
	[CompilerGenerated]
	private sealed class Class278
	{
		// Token: 0x060021F1 RID: 8689 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x040020EC RID: 8428
		public WsWebSender wsWebSender_0;

		// Token: 0x040020ED RID: 8429
		public GClass562 requestToSend;
	}

	// Token: 0x020005A4 RID: 1444
	[CompilerGenerated]
	private sealed class Class279
	{
		// Token: 0x060021F4 RID: 8692 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass560 method_0()
		{
			throw null;
		}

		// Token: 0x040020F5 RID: 8437
		public string msgText;

		// Token: 0x040020F6 RID: 8438
		public WsWebSender wsWebSender_0;
	}

	// Token: 0x020005A5 RID: 1445
	[CompilerGenerated]
	private sealed class Class280
	{
		// Token: 0x060021F5 RID: 8693 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x040020F7 RID: 8439
		public GClass560 response;

		// Token: 0x040020F8 RID: 8440
		public WsWebSender.Class279 class279_0;
	}

	// Token: 0x020005A6 RID: 1446
	[CompilerGenerated]
	private sealed class Class281
	{
		// Token: 0x040020F9 RID: 8441
		public Action<string> action;
	}

	// Token: 0x020005A7 RID: 1447
	[CompilerGenerated]
	private sealed class Class282
	{
		// Token: 0x060021F6 RID: 8694 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x040020FA RID: 8442
		public string notificationParams;

		// Token: 0x040020FB RID: 8443
		public WsWebSender.Class281 class281_0;
	}
}
